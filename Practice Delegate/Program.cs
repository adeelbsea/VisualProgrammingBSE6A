//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Practice_Delegate
//{

//    delegate int Del(int n);

//    class PracticeDelegate
//    {
//        static int num = 10;
//        public static int Add(int p)
//        {
//            return num += p;
//        }

//        public static int Mul(int q)
//        {
//            return num *= q;
//        }

//        public static int getNum()
//        {
//            return num;
//        }

//        static void Main()
//        {
//            Del delob1 = new Del(Add);
//            Del delob2 = new Del(Mul);

//            delob1(25);
//            Console.WriteLine("Value of num: {0}", getNum());
//            delob2(5);
//            Console.WriteLine("Value of num: {0}", getNum());

//            Console.ReadLine();
//        }
//    }
//}




//MULTICAST DELEGATE

//using System;

//delegate int NumberChanger(int n);
//namespace DelegateAppl
//{
//    class TestDelegate
//    {
//        static int num = 10;
//        public static int AddNum(int p)
//        {
//            num += p;
//            return num;
//        }

//        public static int MultNum(int q)
//        {
//            num *= q;
//            return num;
//        }

//        public static int getNum()
//        {
//            return num;
//        }

//        static void Main(string[] args)
//        {
//            //create delegate instances
//            NumberChanger nc;
//            NumberChanger nc1 = new NumberChanger(AddNum);
//            NumberChanger nc2 = new NumberChanger(MultNum);
//            nc = nc1;
//            nc += nc2;

//            //calling multicast
//            nc(5);
//            Console.WriteLine("Value of Num: {0}", getNum());
//            Console.ReadKey();
//        }
//    }
//}





//SLIDE EXAMPLE

//using System; 
//namespace ConsoleApplication1 
//{ 
//    //We can define delegate at name space level & in class 
//    delegate double DoubleOp(double x); 
//    class MathOperations 
//    { 
//        //Both Static and non-static work 
//        public static double MultiplyByTwo(double val) 
//        { return val * 2; } 
//        public static double Square(double val) 
//        { return val * val;} 
//    } 
//    class CSimpleDelegate 
//    { 
//        //What if I make it non static 
//        public static void MyFunction(DoubleOp op,double vals) 
//        { 
//            double res = op(vals); 
//            System.Console.WriteLine(res);
//        }
//        static void Main(string[] args) 
//        {
//            //This is a single cast Delegate
//            DoubleOp Func1 = new DoubleOp(MathOperations.MultiplyByTwo); 
//            double x = Func1(3); 
//            System.Console.WriteLine(x); 
//            Func1 = new DoubleOp(MathOperations.Square); 
//            x = Func1(3); 
//            System.Console.WriteLine(x); 
//            //passing a delegate to another function 
//            MyFunction(Func1,4); 
//            System.Console.ReadLine();
//        } 
//    }//class-end 
//}//namespace-end 
