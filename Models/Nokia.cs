namespace DesafioPOO . Modelos
{
    // TODO: Herdar da aula "Smartphone"
     classe  pública Nokia
     classe  pública Nokia  :  Smartphone
    {
        // TODO: Descrever o método "InstalarAplicativo"
        public  Nokia ( string  numero ,  string  modelo ,  string  imei ,  int  memoria )  :  base ( numer , modelo , imei , memoria )
        {

        }
        public  override  void  InstalarAplicativo ( string  NomeApp )
        {
            Consola . WriteLine ( $" Instalando o aplicativo \" { NomeApp } \" no Nokia " ) ;
        }
    }
}