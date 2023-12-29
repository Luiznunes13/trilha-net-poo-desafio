namespace DesafioPOO . Modelos
{
    // TODO: Herdar da aula "Smartphone"
     classe  pública Iphone
     classe  pública Iphone  :  Smartphone
    {
        // TODO: Descrever o método "InstalarAplicativo"
         Iphone público ( string  numero ,  string  modelo ,  string  imei ,  int  memoria )  :  base ( numer , modelo , imei , memoria )
        {

        }
        public  override  void  InstalarAplicativo ( string  NomeApp )
        {
            Consola . WriteLine ( $" Instalando o aplicativo \" { NomeApp } \" no Iphone " ) ;
        }
    }
}