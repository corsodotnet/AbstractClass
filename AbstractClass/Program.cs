using System;

namespace AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rettangolo ret = new Rettangolo();
            Quadrato quadrato = new Quadrato();
            ret = quadrato;
            FiguraGeometrica figura = ret;

            figura.CalcArea();
        }
    }
    public abstract class FiguraGeometrica
    {
        int Area;
        int Perimentro;
        public abstract int Saldo { get; set; }
        public abstract void CalcArea();

    }
    public interface MyIterace
    {
        public int Saldo { get; set; }
        public void CalPerimentro();
    }
    public class Rettangolo : FiguraGeometrica, MyIterace
    {
        int saldo;
        int interesse;
        public override int Saldo { get; set; }
        public int Saldo1 { get { return saldo + interesse; } set { saldo = value; } }
        public override void CalcArea()
        {
            Console.WriteLine("Calc area Rettangolo");
        }
        public void CalPerimentro()
        {
            Console.WriteLine(" CalPerimentro Rettangolo");

        }
    }

    public class Quadrato : Rettangolo
    {
        //public override void CalcArea()
        //{
        //    Console.WriteLine("Calc area Quadrato");
        //}
    }
}
