# C#面试题

## 目录
- [C#面试题](#c面试题)
  - [目录](#目录)
  - [逻辑运算](#逻辑运算)
  - [进制转换](#进制转换)
  - [数据类型](#数据类型)
  - [类与对象](#类与对象)
  - [委托与事件](#委托与事件)


## 逻辑运算
1. 1 == 1 || 2==2 && 2 == 3的结果是True还是False？(1分)   
   解析：正确答案为True。因为&&的优先级比||高，所以先运算2==2 && 3 == 3，得到False，这个结果再和1 == 1进行或运算，得到True。
   如果你误以为||与&&的优先级相同，那么你会先运算1 == 1 || 2== 2，得到True，这个结果再和2 == 3进行与运算，得到False。  
    题外话：在工作中，经常会在if语句中判断多个条件的组合。要先搞清楚业务逻辑，然后用代码表达条件组合时要表达正确，我见过一些新手不知道
    这个知识点导致条件判断出了问题，然后用了很多括号来强行纠正。

2. 理解以下代码：
   ```
    int a = 1;
    int b = 0;
    Random r = new Random();
    if (a == 1 || (b=r.Next()) == 100)
    {
        Console.WriteLine(b);
    }
   ```
   问：程序输出？  
    解析：0。这里主要考察在if分支判断时的自动优化情况。在if分支判断表达式时，如果表达式中第一个逻辑运算符为||，并且“||”前面的结果是True，
    那么程序会忽略（不执行）“||”后面的所有内容，直接返回True。因为对于“||”来说，只要有一边的结果为True，无论另一边结果是什么，最终都返回True；
    同理，如果表达式中第一个逻辑运算符为&&，并且“&&”前面的结果是False，那么会忽略（不执行）“&&”后面的所有内容，直接返回False。  
    题外话：我想强调的是b=r.Next()是不执行的，在工作实践中，这里可能会是一些重要的方法调用，如果因为写的人不知道这个知识点而导致了这个错误，
    那真是不应该。

## 进制转换

1. Int32类型的十进制与十六进制如何互转（不通过格式化字符串方式）？（2分）  
    解析：  
    （首先如果答者直接表明这样的意思：进制只是数字的一种表现形式，其核心是存在内存/字节里的二进制内容，那么可以不用理会后面的内容直接得2分。）  
    既然是Int32类型，那么在内存中所占的就是四个字节，我们无法直接获取这四个字节的真实内容，但是
    我们可以通过计算来得到一个模拟的内存/字节数据（讲到这点给1分），具体地，我们可以通过对数据做位移和位运算操作（讲到这点给1分）来得到
    字节内容，有了该内容后，之后想转换成几进制，只需要按照一定的转换规则进行计算即可。  
    题外话：在网络编程（如串口通信）中，我们经常要把信息转换成字节数组进行传输，以及接收到后再将其转换回我们能看得懂的有效信息。  

2. 讲一下如何将一个Int类型转换为高八位与低八位（1分）
    解析：通过位移和位与运算即可得到。举个例子，数字为100，先将100与0xFF进行位与运算，得到低八位，再将100向右位移8位，再与0xFF进行位
    与运算，得到高八位。  
    题外话：这种操作在串口编程时十分常见，目前了解即可。

## 数据类型



## 类与对象


## 委托与事件