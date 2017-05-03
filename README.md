

# CashCoreMVCAngular

Contains a prove of concept for when using a multi-layer approach using angular 2 web api, mvc and wcf.
This was develop using vs 2017 I had problems running vs 2015, you can read more about it running both version on the same machine on the following url: 
https://github.com/aspnet/Tooling/blob/master/known-issues-vs2015.md#missing-sdk
Hope you enjoy as much as I did making it.
Thanks

Contains a prove of concept for when using a multi-layer approach using angular 2 web api, mvc and wcf.
The original brief was:
There is a special cash machine, without any security, that dispenses money (notes and coins). The machine has a given initial state of what coins and notes it has available.  
The initial state is: 100x1p, 100x2p, 100x5p, 100x10p, 100x20p, 100x50p, 100x£1, 100x£2, 50x£5, 50x£10, 50x£20, 50x£50. 
You should create a program that is given the value to withdraw as an input. 
Program the cash machine, so it has 2 algorithms that can be swapped (swapping can be done by rebuilding and rerunning the application): 
1. Algorithm that returns least number of items (coins or notes) 
2. Algorithm that returns the highest number of £20 notes possible 
Output the number of coins and notes given for each withdrawal. 
The machine should output the count and value of coins and notes dispensed and the balance amount left. 
The program should be extendible and written using .NET framework. Use the best approach you can to implement the solution: 
* Front End – one of web frameworks: Aurelia JS/Angular/… 
* Back End – Web API/ASP.NET  Core/ …  
Examples 
 
ALGORITHM 1 
Input (Withdrawal amount) 
120.00 
Output 
£50x2, £20x1 
£X.XX balance 
 
ALGORITHM 2 
Input 
120.00 
Output 
£20x6 
£X.XX balance 

