using System;  
public class VowelConsonant  
{  
    public static void Main() 
{
    string str;
    int alp, digit, splch, i,l;
    alp = digit = splch = i = 0;


     
      str = Console.ReadLine();	
      l=str.Length; 

  

    while(i<l)
    {
        if((str[i]>='a' && str[i]<='z') || (str[i]>='A' && str[i]<='Z'))
        {
            alp++;
        }
        else if(str[i]>='0' && str[i]<='9')
        {
            digit++;
        }
        else
        {
            splch++;
        }

        i++;
    }

   Console.Write(" Alphabets{0}\n", alp);
   Console.Write(" Digits{0}\n", digit);
   Console.Write(" Special \n characters{0}\n\n", splch);
	}
}


