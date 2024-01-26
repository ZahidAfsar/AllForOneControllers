using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllForOneControllers.Services.Third;

    public class ThirdService : IThirdService
    {
        public string CompareNums(string numOneString, string numTwoString)
    {
        int numOne;
        int numTwo;
        bool isNumOne = int.TryParse(numOneString, out numOne);
        bool isNumTwo = int.TryParse(numTwoString, out numTwo);

        if(isNumOne && isNumTwo){
        if( numOne > numTwo){
                return $"{numOne} is greater than {numTwo} and {numTwo} is less than {numOne}";
            }else if(numOne < numTwo){
                return $"{numOne} is less than {numTwo} and {numTwo} is greater than {numOne}";
            }else{
                return "Your first number is equal to your second and your second number is equal to your first";
            }
            }else{
                return $"Please use a number";
            }
        }
    }
