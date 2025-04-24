## 概念

- wpf:wpf是一个基于.net平台的UI框架，它使用xaml语言描述UI结构，与winform相比它的界面灵活性要更高一些。
  
### xaml相关
因为微软文档中对于xaml内容中的概念较多，因此专门搞个小节总结一下。  
- 对象元素：举例：
```
<StackPanel>
  <Button Content="Click Me"/>
</StackPanel>
```
\<StackPanel\>\</StackPanel\>和\<Button/\>都是对象元素

- 特性语法（属性）:在上述例子中，Content="Click Me"就是特性语法，特性名称（Content）必须与类属性名一致，特性值必须使用双引号包括。  
xaml解析器在解析特性值时，会优先按照标记扩展（大括号包括内容），typeconverter，属性类型的顺序进行解析。
- 属性元素语法：举例：  
```
<Button>
  <Button.ContextMenu>
    <ContextMenu>
      <MenuItem Header="1">First item</MenuItem>
      <MenuItem Header="2">Second item</MenuItem>
    </ContextMenu>
  </Button.ContextMenu>
  Right-click me!</Button>
```
\<Button.ContextMenu\>就是属性元素，ContextMenu为Button中的一个对象属性，\<Button.ContextMenu\>标签中的内容会转换为一个对象作为ContextMenu的值。  
- 集合语法：首先，该属性得是一个集合类型，符合以下条件之一即可：
  + 实现IList接口
  + 实现IDictionary接口
  + 派生自Array
```
<LinearGradientBrush>
  <LinearGradientBrush.GradientStops>
    <!-- no explicit new GradientStopCollection, parser knows how to find or create -->
    <GradientStop Offset="0.0" Color="Red" />
    <GradientStop Offset="1.0" Color="Blue" />
  </LinearGradientBrush.GradientStops>
</LinearGradientBrush>
```
<LinearGradientBrush.GradientStops>就是一个集合属性
- 内容属性：即Child属性，通常可省略。举例：
```
<Border>
  <TextBox Width="300"/>
</Border>
<!--explicit equivalent-->
<Border>
  <Border.Child>
    <TextBox Width="300"/>
  </Border.Child>
</Border>
```
- 文本内容：即Content属性，有少量 XAML 元素可直接将文本作为其内容来处理。 若要实现此功能，必须满足以下条件之一：
  + 类必须声明一个内容属性，并且该内容属性必须是可赋值给字符串的类型（该类型可以是 Object）。
  + 类型必须声明一个类型转换器，该类型转换器将文本内容用作初始化文本。例如，\<Brush\>Blue\</Brush\> 将 Blue 的内容值转换为画笔。 这种情况实际上并不常见。
- 标记扩展：举例：
```
<Button Style="{StaticResource MyStyle}">My button</Button>
```
{StaticResource MyStyle}就是标记扩展，xaml解析器遇到标记扩展时会根据其内容生成对象赋给属性。

如有异议，详情见[某乎文章](https://zhuanlan.zhihu.com/p/661914689)及[微软doc](https://learn.microsoft.com/zh-cn/dotnet/desktop/wpf/advanced/xaml-syntax-in-detail?view=netframeworkdesktop-4.8)

（吐槽：这些概念在看的时候真的是CPU都要干烧了，书面描述实在太抽象了）


## 需要理解的知识点

- xaml的命名空间  
  xaml的命名空间和xml的作用是差不多的。首先，都是用于区分来源不同的名称重复的元素；其次，xaml的命名空间的uri可能还有其他作用，比如要引用一个程序集中的类时，就需要通过命名空间进行引入，此时uri中要包含该程序集的名称以及需要用到的命名空间。

