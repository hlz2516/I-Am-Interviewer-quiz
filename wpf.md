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
< StackPane l>< /StackPanel >和< Button />都是对象元素

- 特性语法（属性）:在上述例子中，



## 需要理解的知识点

- xaml的命名空间  
  xaml的命名空间和xml的作用是差不多的。首先，都是用于区分来源不同的名称重复的元素；其次，xaml的命名空间的uri可能还有其他作用，比如要引用一个程序集中的类时，就需要通过命名空间进行引入，此时uri中要包含该程序集的名称以及需要用到的命名空间。

