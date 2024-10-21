Requirements:

Write a C# program that defines a method that takes a string input and masks sensitive data in it, such as credit card numbers and social security numbers.

Your program should replace the sensitive data with a mask character ('X' character).

Your program should detect credit card numbers based on their format, such as "XXXX-XXXX-XXXX-XXXX", where "X" is a digit.

Your program should detect social security numbers based on their format, such as "XXX-XX-XXXX", where "X" is a digit.

Your program should be case-sensitive.

Your program must compile without errors and run successfully.

Use comments in your code to explain the purpose and functionality of your method.

Test your program with at least one sample input and output.

Methods to create:

MaskCreditCard(string input): Write a method that takes a string input and masks all credit card numbers in it. It should preserve only last four digits. For example, if the input string is "My credit card number is 1234-5678-9012-3456", the output string should be "My credit card number is XXXX-XXXX-XXXX-3456".

MaskSocialSecurity(string input): Write a method that takes a string input and masks all social security numbers in it. It should preserve only middle two digits. For example, if the input string is "My social security number is 123-45-6789", the output string should be "My social security number is XXX-45-XXXX".

MaskData(string input): Write a method that takes a string input and masks all credit card numbers and social security numbers in it. It invokes the above methods - MaskCreditCard and MaskSocialSecurity. For example, if the input string is "My credit card number is 1234-5678-9012-3456 and my social security number is 123-45-6789", the output string should be "My credit card number is XXXX-XXXX-XXXX-3456 and my social security number is XXX-45-XXXX".



Sample inputs:

My credit card number is 1234-5678-9012-3456
My social security number is 123-45-6789
My credit card number is 1234-5678-9012-3456 and my social security number is 123-45-6789


Sample output:

My credit card number is XXXX-XXXX-XXXX-3456
My social security number is XXX-45-XXXX
My credit card number is XXXX-XXXX-XXXX-3456 and my social security number is XXX-45-XXXX
