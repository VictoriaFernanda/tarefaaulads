using  System ;
usando o  sistema . Coleções . Genérico ;
usando o  sistema . Texto ;

namespace  adm_Saladeaula
{
     classe  pública Aluno
    {
        Lista < base_aluno > lista_chamada  =  nova  Lista < base_aluno > ();
    }
}
 public  void  listar ()
{
    if ( lista_chamada . Contagem  >  =  0 )
    {
        Console . BackgroundColor  =  ConsoleColor . DarkBlue ;
        Console . WriteLine ( " Nome Número Notas Faltas " );
        Console . BackgroundColor  =  ConsoleColor . Preto ;

        para ( int  i  =  0 ; i  <  lista_chamada . Contagem ; i ++ )
        {
            Console . WriteLine (
            " {0} {1} {2} {3} "
            eu ,
            lista_chamada [ i ]. Nome ,
            lista_chamada [ i ]. Notas . ToString (),
            lista_chamada [ i ]. Faltas . ToString ()
            );
        }
    }





   senão
    {
      Console . BackgroundColor  =  ConsoleColor . Vermelho ;
       Console . WriteLine ( " Não há alunos fora do sistema " );
       Console . BackgroundColor  =  ConsoleColor . Preto ;
    }
}

public  void  excluir_aluno ()
{
    if ( lista_chamada . Contagem  >  0 )
    {
        Console . WriteLine ( " Informe o numero do aluno que deseja excluir " );
        int  i = Converter . ToInt32 ( Console . ReadLine ());
        lista_chamada  RemoveAt (i);

        Console . BackgroundColor  =  ConsoleColor . Vermelho ;
        Console . WriteLine ( " Aluno excluído! " );
        Console . BackgroundColor  =  ConsoleColor . Preto ;
    }
    senão
    {
        Console . BackgroundColor  =  ConsoleColor . Vermelho ;
        Console . WriteLine ( " Nenhum aluno foi excluído do sistema " );
        Console . BackgroundColor  =  ConsoleColor . Preto ;
    }
}

public  void  editar_nota ()
{
    if ( lista_chamada . Contagem  >  0 )
    {


        Console . WriteLine ( " Qual o número do aluno que deseja editar a nota? " );
        int  i  =  Converter . ToInt32 ( Console . ReadLine ());
        Console . WriteLine (
            " Qual a nota de {0}? A nota atual é {1} "


             lista_chamada [ i ]. Nome ,
             lista_chamada [ i ]. Notas
             );
        lista_chamada [ i ]. Notas  Convert . ToDouble ( Console . ReadLine ());

        Console . BackgroundColor  =  ConsoleColor . Ciano ;
        Console . WriteLine ( " A nota do aluno foi editada! " );
        Console . BackgroundColor  =  ConsoleColor . Preto ;
    }


    senão
    {
        Console . BackgroundColor  =  ConsoleColor . Vermelho ;
        Console . WriteLine ( " A nota não foi alterada " );
        Console . BackgroundColor  =  ConsoleColor . Preto ;
    }
}

public  void  editar_falta ()
{

    if ( lista_chamada . Contagem  >  0 )
    {
        Console . WriteLine ( " Qual o número do aluno que deseja editar como faltas? " );
        int  i  =  Converter . ToInt32 ( Console . ReadLine ());
        Console . WriteLine (
        " Quantas faltas {0} tem? Total de faltas: {1} " ,
        lista_chamada [ i ]. Faltas ,
        lista_chamada [ i ]. Nome
        );

        lista_chamada [ i ]. Faltas  =  converter . ToDouble ( Console . ReadLine ());

        Console . BackgroundColor  =  ConsoleColor . DarkBlue ;
        Console . WriteLine ( " As faltas foram editadas com sucesso! " );
        Console . BackgroundColor  =  ConsoleColor . Preto ;
        Console . BackgroundColor  =  ConsoleColor . Vermelho ;

        Console . WriteLine ( " Nenhuma falta foi alterada " );
        Console . BackgroundColor  =  ConsoleColor . Preto ;
    }
}
