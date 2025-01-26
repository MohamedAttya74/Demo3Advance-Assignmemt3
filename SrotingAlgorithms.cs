using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3Advance_Assignmemt3
{

    //public delegate TResult CustonFunc<  in T1 , in T2 ,out  TResult>(T1 arg01, T2 arg02);
    internal/* static*/ class SrotingAlgorithms <T>
    {
        public static void BubbleSort(/* this*/ T[] element  , Func<T , T ,bool > func          /*ICustomComparer comparer*/ )
        {
            if (element == null || func is null) return;
            for (int i = 0; i < element.Length; i++)
            {
                for (int j = 0; j < element.Length - 1 - i; j++)
                {
                    //if (Number[j] > Number[j + 1])
                    //if (comparer.Compare(Number[j], Number[j + 1])) // Stratigy Design Pattern هو دا ال 
                    if (func.Invoke(element[j], element[j + 1])) 
                    {
                     /* SrotingAlgorithms<T>.*/Swap(ref element[j], ref element[j + 1]);
                    }
                }

            }
        }

        private static void Swap(ref T X , ref T  Y)
        {
            T Temp = X;
            X = Y; 
            Y = Temp;
        }
    }

///  class SortingTypes
/// {
///  public static bool CompareGrt(int X, int Y) => X > Y; // Sort Asending 
///  public static bool CompareLess(int X, int Y) => X < Y;// Sort Desending
/// 
/// 
/// 
/// 
/// 
/// }
/// 



    class ComparasionTypes
    {

        public static bool CompareGrt(int X, int Y) => X > Y; // Sort Asending 
        public static bool CompareGrt(string X, string Y) => X.CompareTo(Y) == 1; // Sort Asending 
       
        
        public static bool CompareLess(int X, int Y) => X < Y;// Sort Desending
         public static bool CompareLess(string X, string Y) => X .CompareTo( Y) == -1 ;// Sort Desending
        
    }
}



//    Genaric     واحده بس لازم يكون في اختلاف ال   NameSpace    عندهم نفس الاسم جوه  Class   اقدر اعمل اكتر من 
//    عادي  methode    فهيقدر يورث هذه ال   Class GrandChild inherte from  Class Child    انما لو في  private   عباره عن  Class Child دي ف ال  Methode هتكوت ال  inherte from Class Parent  بي Class Child   وفي   protected Methode  عندو   Class Parent    لو في 