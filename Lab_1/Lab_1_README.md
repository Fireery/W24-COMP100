Lab 1 - Data Types

1. 
Create a program that prompts the user for her first name, middle initial and last name. The program will display the username three times using the following three formats: 
first name and last name
first name middle initial and last name
last name, first name and middle initial
Example for inputs Barack H Obama
Barack Obama
Barack H Obama
Obama, Barack H
Remember to insert the dollar symbol ($) before your double quotes in the Console.Write/WriteLine statement.
创建一个程序，提示用户输入名字、中间名首字母和姓氏。 该程序将使用以下三种格式显示用户名三次：
名字和姓氏
名字中间名首字母和姓氏
姓氏、名字和中间名首字母
输入示例: Barack H Obama
Barack Obama
Barack H Obama
Obama, Barack H
请记住在 Console.Write/WriteLine 语句中的双引号前插入美元符号 ($)。

2. 
Write a program that prompts the user for the number of siblings his has. The program should display a message, “I also have 4 siblings” (assuming that the user enters 4).
In this question, you are not doing any arithmetic so you may use string type for the input.
编写一个程序，提示用户输入the number of siblings his has。 程序应显示一条消息“I also have 4 siblings”（假设用户输入 4）。
在这个问题中，您没有进行任何算术运算，因此您可以使用字符串类型作为输入。

3. 
Write a program that prompts the user for two integers. The program will display the result of summing and finding the difference. (If the user enters 8 and 3, the display should be 8 + 3 = 11 and 8 – 3 = 5).
Use the Convert.ToInt32() method to obtain an int from an input.
编写一个程序，提示用户输入两个整数。 程序将显示求和求差的结果。 （如果用户输入 8 和 3，则显示应为 8 + 3 = 11 和 8 – 3 = 5）。
使用 Convert.ToInt32() 方法从输入获取 int。

4. 
Write a program that prompts the user for the number of siblings his has. The program should display a message, “I have 4 siblings” (assuming that the user enters 3). This question is not the same as question 2.


5. 
Write a program to prompt the user to enter a single character. The program should display a message like “Your response was y”. For this question, you must use a variable of type char
Use the Convert.ToChar() method to obtain a char from an input.

6. 
Write a program to ask the user about the validity of a simple statement. The program should accept the response then display the statement as well as the response. The response should be true or false. For this question, you must use a variable of type bool. It is useful to know that Convert.ToBoolean() can work with true, True, tRue, TRUE etc.
Use the Convert.ToBoolean() method to obtain a bool from an input.

7. 
Write a program to calculate the area of a circle. The user will enter the radius of the circle and the program will calculate and display the area according to the formula (area = 3.14 * radius * radius). You must accept fractions as the input. If the user enters 1.2 for the radius then the area will be 4.52. (Use the "F" format-specifier for floating point values).
Use the Convert.ToDouble() method to obtain a double from an input.

8. 
Write a program that prompts the user for a number (that may be a fraction). The program reads in the input and print the following: the input as a double, the input as an int and finally the input as a char.
e.g. if the input is 65.790, then the output will be 65.790, 65, and A.
Use the appropriate method of the Convert class

9. 
Adult ticket cost $3.75 and child ticket cost $2.25. Write a program to prompt the user for the amount of adult and child ticket that she needs. The program will display a user-friendly message of the number of tickets brought as well as the total cost. (Use the "C" format-string for currency).

10. 
Write a program to calculate and display the potential difference between the ends of a wire. The program will prompt the user for the current flowing and the resistance of the wire. Potential difference is the product of the current and the resistance of the wire and may include a fractional part. (Again, use the "F" format-specifier for floating point values).