namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var a = new A();
            a.AProp = 10;

            var b = new B();
            b.AProp = 10;
            b.BProp = 20;

            var c = new C();
            c.AProp = 10;
            c.CProp = 20;

            var d = new D();
            d.AProp = 10;
            d.BProp = 20;
            d.DProp = 20;
        }
    }
    // Base Class
    class A
    {
        public int AProp { get; set; }
    }

    class B : A
    {
        public int BProp { get; set; }
    }
    class C : A
    {

        public int CProp { get; set; }
    }

    class D : B
    {

        public int DProp { get; set; }
    }


}
