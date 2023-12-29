namespace DesafioPOO . Modelos
{
     classe abstrata  pública Smartphone 
    {
         string  pública Número  {  get ;  definir ;  }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
         string  protegida Modelo  {  get ;  definir ;  }
         string  protegida IMEI  {  obter ;  definir ;  }
        protegido  int  Memória  {  get ;  definir ;  }

         Smartphone público ( string  numero )
         Smartphone público ( string  numero , string modelo , string imei , int memoria )      
        {
            Número  =  numero ;
            // TODO: Passar as configurações do construtor para as propriedades
            Modelo  =  modelo ;
            IMEI  =  imei ;
            Memória  =  memória ;
        }

        public  void  Ligar ( )
        {
            Consola . WriteLine ( " Ligando... " ) ;
        }
        public  void  ReceberLigação ( )
        {
            Consola . WriteLine ( " Recebendo conexão... " ) ;
        }
        public  abstract  void  InstalarAplicativo ( string  nomeApp ) ;
    }
}