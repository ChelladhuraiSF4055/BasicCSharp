using System;
namespace Question3;
class Program{
    public static void Main(string[] args)
    {
        char temp;
        int flag=0;
        Console.Write("NameOne: ");
        char []  arr1=Console.ReadLine().ToCharArray();
        Console.Write("NameTwo: ");
        char [] arr2=Console.ReadLine().ToCharArray();
        if(arr1.Length==arr2.Length)
        {
            for(int i=0;i<arr1.Length;i++)
            {
            int j=i;
                while(j<arr1.Length)
                {
                    if(arr1[i]>arr1[j])
                    {
                        temp=arr1[i];
                        arr1[i]=arr1[j];
                        arr1[j]=temp;
                    }
                    j++;
                }
            }
            for(int i=0;i<arr2.Length;i++)
            {
            int j=i;
            int k=j;
                while(k<arr2.Length)
                {
                    if(arr2[j]>arr2[k])
                    {
                        temp=arr2[j];
                        arr2[j]=arr2[k];
                        arr2[k]=temp;
                    }
                    k++;
                }
            }
            
                for(int i=0;i<arr1.Length;i++)
                {
                    if(arr1[i]!=arr2[i])
                    {
                        flag=1;
                    }
                }
        
        if(flag==0)
        {
            Console.WriteLine("Name One and Two are anagrams");
        }
        else
        {
            Console.WriteLine("Name One and Two are'nt anagrams");
        }
        }
        else
        {
            Console.WriteLine("Name One and Two are'nt anagrams");
        }
    }
}