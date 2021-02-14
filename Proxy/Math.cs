namespace Proxy
{
    class Math:IMath
    {
        public double Topla(double x,double y){return x+y;}
        public double Cikar(double x,double y){return x-y;}
        public double Carp(double x,double y){return x*y;}
        public double Bol(double x,double y){return x / y;}
    }
    class MathProxy:IMath{
        private Math _math = new Math();
        public double Topla(double x,double y){
            return _math.Topla(x,y);
        }
        public double Cikar(double x,double y){
            return _math.Cikar(x,y);
        }
        public double Carp(double x, double y){
            return _math.Carp(x,y);
        }
        public double Bol(double x, double y){
            return _math.Bol(x,y);
        }
    }
}