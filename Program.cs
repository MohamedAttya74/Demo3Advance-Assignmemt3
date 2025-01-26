namespace Demo3Advance_Assignmemt3
{
    // Step 0. Delegate Declearation 
    public delegate int CustonFunc(string arg01);  //==> IL    جوه ال   Class هيتحول الي  
    /// New Delegate (Class) , The Referance from this Delegate can Refare To a Function or More [Pointer To Functions]
    /// These Function Can be Class Member[Static] or Object Memder [Non-Static]
    /// Thess Functions Must Have the Same Signature OF the Delegate  : int(string)
    /// Regardless Function Access Modifire RegardLess Naming (Function,Paramiters )

    //public delegate bool CustomPredicate< in T>(T Obj);
    
    internal class Program
    {

        public static List<T> FindElement<T>(List<T> Element, Predicate<T> predicate)
        { 
        List<T> Result = new List<T>();

            if (Element?.Count > 0) {

                foreach (var number in Element)
                {
                    //if(number %2 ==1)
                    if (predicate(number))

                        Result.Add(number);
                }
            }
        return Result;
        
        }
        /*
         public static List<T> FindNumbers<T>(List<T> Numbers, CustomPredicate<T> predicate)
        { 
        List<T> Result = new List<T>();

            if (Numbers?.Count > 0) {

                foreach (var number in Numbers)
                {
                    //if(number %2 ==1)
                    if (predicate(number))

                        Result.Add(number);
                }
            }
        return Result;
        
        }
         
         */


        public static Action DelegateDoAction()
        {
            //return delegate () { Console.WriteLine("Hello World"); };
            return  () => Console.WriteLine("Hello World"); 
        }
        static void Main(string[] args)
        {
            /// Dileget is a C# Language Feature [C# 2.0]
            /// Has 2 Usages : 
            /// 1- fanctional Programming Paradiam 
            /// 2- Event-Driven Programming Paradiam

            #region Delegate Example 01

            ///   // Step  1. Declaer Delagate Referance 
            /// 
            ///   Func<string,int> Referance;
            /// 
            ///   // Step 2. Initalize the Delagate Referance[ Pointer To Functions ] 
            ///   //Referance = new CustonFunc(StringFunctions.GetCountOfUpperCaseChars);
            ///   Referance = StringFunctions.GetCountOfUpperCaseChars; //"Syntax Suger"
            ///  //Referance += StringFunctions.GetCountOfLowerCaseChars; // Not Need Do This Operations 
            ///  //Referance -= StringFunctions.GetCountOfUpperCaseChars; // Not Need Do This Operations
            /// 
            ///   
            ///   // Step 3. Use the Delegate Referance 
            ///  int Result =  Referance.Invoke("MoHaMeD");
            ///   //Result= Referance("MoHaMeD");//"Syntax Suger"
            ///   Console.WriteLine($"Result = {Result}"); 
            #endregion

            #region Delegate Example 02
            ///    int[] Numbers = [8, 2, 9, 5, 10, 7, 3, 6, 1, 4];
            ///    //SrotingAlgorithms.BubbleSort(Numbers, new DscComparer());
            ///    //SrotingAlgorithms.BubbleSort(Numbers, new AscComparer());
            ///    //Numbers.BubbleSort( new AscComparer());  //static حطيت  class  وعند ال  this   وهو اني حطيت  Extantion Method    خليتها 
            /// 
            /// 
            /// 
            ///    Func<int , int ,bool > func = ComparasionTypes.CompareGrt;
            ///    //func = default!;  // null
            ///    //SrotingAlgorithms.BubbleSort(Numbers, SortingTypes.CompareGrt);
            ///    SrotingAlgorithms<int>.BubbleSort(Numbers, func);
            ///    //SrotingAlgorithms.BubbleSort(Numbers, delegate (int X, int Y) { return X < Y; });
            ///    //SrotingAlgorithms.BubbleSort(Numbers,  ( X,  Y)=>  X < Y ); 
            /// 
            ///    foreach (int number in Numbers)
            ///    {
            ///        Console.WriteLine(number);         
            ///    }
            /// 

            ///  string[] Names = ["Omar", "Nada", "Ziad", "Amer", "Mona", "Yamal" , "Eyad" , "Emad"];
            ///  Func<string, string, bool> Func02 = ComparasionTypes.CompareGrt;
            /// 
            /// 
            ///  SrotingAlgorithms<string>.BubbleSort(Names, Func02);
            ///  //SrotingAlgorithms<string>.BubbleSort(Names,ComparasionTypes.CompareLess);
            /// 
            ///  foreach (string name in Names)
            ///  {
            ///      Console.WriteLine(name);
            ///  }
            /// 


            #endregion

            #region Delegate Example 03
            #region Find Odds

            ///   List<int> Numbers = Enumerable.Range(0, 100).ToList();//0...99        // ToList()   ف عملت  Array  علشان هو بيرجع 
            ///  Predicate<int> predicate = ConditionFunctions.IsOdd;
            ///   
            ///   
            ///   List<int> Odd = FindElement(Numbers, predicate);
            ///  
            ///   
            ///   
            ///   foreach (int number in Odd)
            ///   {
            ///       Console.Write($"{number}");
            ///       Console.WriteLine();
            ///       Console.WriteLine();
            ///   } 
            #endregion

            //   Console.WriteLine("**********************");

            #region Find Even 
            /// //   List<int> Numbers = Enumerable.Range(0, 100).ToList();//0...99        // ToList()   ف عملت  Array  علشان هو بيرجع 
            /// predicate = ConditionFunctions.IsEven;
            /// List<int> Even = FindElement(Numbers, predicate);
            /// foreach (int number in Even)
            ///   {
            ///       Console.Write($"{number}");
            ///       Console.WriteLine();
            ///       Console.WriteLine();
            ///   }
            #endregion

            // Console.WriteLine("**********************");

            #region FindElementDivisableBySeven 

            /// predicate = ConditionFunctions.IsDivisableBySeven;
            /// List<int> NumbersDivisableBySeven = FindElement(Numbers, predicate);
            /// foreach (int number in NumbersDivisableBySeven)
            /// {
            ///     Console.Write($"{number}");
            ///     Console.WriteLine();
            ///     Console.WriteLine();
            /// } 
            #endregion


            /// Predicate<string> predicate02;
            /// predicate02 = ConditionFunctions.IsLenghtMorethan04;
            ///  List<string> Names = new List<string>(10) { "Ahmed" , "Nadia" ,"Amany" , "Ali" ,"Aya" , "Ola" };
            /// 
            ///  List<string> NamesWithLenghMoreThan04 = FindElement<string>(Names, predicate02);
            /// 
            ///  foreach (string name in NamesWithLenghMoreThan04)
            ///  {
            ///      Console.WriteLine(name);
            ///      Console.WriteLine("");
            ///      Console.WriteLine("");
            ///  }



            #endregion

            #region Built-In Delegate [Predicate ,Func , Action ]

            //Predicate<int> predicate = SomeFunctions.Test;  //   One Parameter and Return bool   بتاخد Function اقدر اشاور علي 
            //predicate.Invoke(10);
            ////predicate(10);


            //Func<int, string> func = SomeFunctions.Cast; // Void تكون   Function ولازم ال   Parameter 16  بتقبل لحد  Function   وبتشاور علي   Overload  عندها 17 
            //func.Invoke(10); // ممكن كدا 
            //                 //func(10);     // وممكن كدا 


            //Action<string> action = SomeFunctions.Print;
            //action.Invoke("Mohamed");

            #endregion

            #region Anonymous Function Vs Lamda Expression
            /// // Anonymous Function : C# 2.0 Feature (.NET Framework 2.0 [2005] )
            ///   Predicate<int> predicate =delegate  (int Number) { return Number > 0; };  //   One Parameter and Return bool   بتاخد Function اقدر اشاور علي 
            ///   predicate.Invoke(10);
            ///   //predicate(10);
            ///  
            ///  
            ///   Func<int, string> func = delegate(int Number) { return Number.ToString(); }; // Void تكون   Function ولازم ال   Parameter 16  بتقبل لحد  Function   وبتشاور علي   Overload  عندها 17 
            ///   func.Invoke(10); // ممكن كدا 
            ///                    //func(10);     // وممكن كدا 
            ///  
            ///  
            ///   Action<string> action = delegate (string Name) { Console.WriteLine($"Hello {Name}"); };
            ///   action.Invoke("Mohamed");


            ///   //Lamda Expression :C# 3.0  Feature (.NET Framework 3.5 [2007]   
            ///   // => Called as 'FatArrow' and Read as 'GoesTo '
            ///     
            ///     Predicate<int> predicate =  Number =>   Number > 0 ;  //   One Parameter and Return bool   بتاخد Function اقدر اشاور علي 
            ///   predicate.Invoke(10);
            ///   //predicate(10);
            ///  
            ///  
            ///   Func<int, string> func =   Number => Number.ToString();  // Void تكون   Function ولازم ال   Parameter 16  بتقبل لحد  Function   وبتشاور علي   Overload  عندها 17 
            ///   func.Invoke(10); // ممكن كدا 
            ///                    //func(10);     // وممكن كدا 
            ///  
            ///  
            ///   Action<string> action =  Name => Console.WriteLine($"Hello {Name}"); 
            ///   action.Invoke("Mohamed");

            #endregion

            #region New Feature in Delegate Using "var" Keyword
            ///    // var Keyword -> Implicitly Typed Local Variable [C# 2.0] 
            ///    var predicate = (int Number) => Number > 0; 
            ///    predicate.Invoke(10);
            ///    //predicate(10);
            ///
            ///
            ///   var  func =(int Number) => Number.ToString();
            ///    //Func<int, string>
            ///    func.Invoke(10); 
            ///                       
            ///
            ///
            ///   var action = (string Name) => Console.WriteLine($"Hello {Name}");
            ///    // Action<string>
            ///    action.Invoke("Mohamed");

            #endregion
            #region List Methods That Take Function as Aparameter 

            //  List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //  //List<int> OddNumbers = FindElement(Numbers,ConditionFunctions.IsOdd);

            //  //List<int> OddNumbers = FindElement(Numbers, delegate (int Number) { return Number % 2 == 1; });
            //  //List<int> OddNumbers = FindElement(Numbers,  ( Number)  => Number % 2 == 1);

            //  //List<int> OddNumbers = Numbers.FindAll(N => N % 2 == 1);
            //       //Numbers.Find(N => N % 2 == 1); // 1
            //   //     Numbers.FindLast(N => N % 2 == 1);
            //  ///   foreach (int Number in OddNumbers) {
            /////       Console.WriteLine(Number);
            /////   
            /////   }

            //  Numbers.Exists(X => X> 0);
            //  Numbers.TrueForAll(X => X> 0); //  Condition   تكون بتحقق ال  ELement  لازم كل ال 
            //  Numbers.ForEach (N => {
            //      N += 10;
            //  });
            //  Numbers.RemoveAll(X => X % 2 == 0);
            //  foreach (int Number in Numbers)
            //  {
            //           Console.WriteLine(Number);

            //       } 
            #endregion
      
        
               DelegateDoAction()();
        
        
        
        
        }
        class SomeFunctions
        {
            //public static bool Test(int Number) { return Number > 0; }
            //public static string Cast(int Number) { return Number.ToString(); }
            //public static void Print(string Name) { Console.WriteLine($"Hello {Name}"); }

        }
        class StringFunctions
        {
            public static int GetCountOfUpperCaseChars(string Name)
            {

                Console.WriteLine("GetCountOfUpperCaseChars");
                int count = 0;

                if (Name is not null) {

                    for (int i = 0; i < Name.Length; i++)
                        if (char.IsUpper(Name[i]))
                            count++;  
                }

                return count;






            }
            public static int GetCountOfLowerCaseChars(string Name)
            {
                Console.WriteLine("GetCountOfLowerCaseChars");
                int count = 0;

                if (Name is not null) {

                    for (int i = 0; i < Name.Length; i++)
                        if (char.IsLower(Name[i]))
                            count++;  
                }

                return count;






            }
        }

        class ConditionFunctions
        {
            //public static bool IsOdd(int Number) => Number % 2 == 1;
            public static bool IsEven(int Number) => Number % 2 == 0;
            public static bool IsDivisableBySeven(int Number) => Number % 7 == 0;
            public static bool IsLenghtMorethan04(string Name) => Name?.Length > 4;
        
        
        }


    }
}
 