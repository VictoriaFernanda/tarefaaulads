using  System ;
usando o  sistema . Coleções . Genérico ;
usando o  sistema . Globalização ;
usando o  sistema . Linq ;

namespace  Saladeaula
{
    public  class  Programa : ProgramBase
    {
         const  privada ConsoleColor  darkBlue1  =  ConsoleColor . DarkBlue ;
         const  privada ConsoleColor  darkBlue  =  darkBlue1 ;

        static  void  Main ( string [] args )
        {

            bool  voltar_menu_inicial  =  false ;

            int  opcao_menu ;

            Aluno  dados_alunos  =  novo  Aluno ();

            Faz
            {
                Console . Limpar ();


                Console . BackgroundColor  =  darkBlue2 ;



 Console . WriteLine ( " Deseja voltar ao menu? Sim ou não " )
 voltar_menu  = ( Console . ReadLine (). ToUpper () ==  " sim " ) ?  verdadeiro  :  falso ;
            } enquanto ( voltar_menu );
 Console . WriteLine ( " FIM (: " );
Console . ReadKey ();


            switch ( opcao_menu )
            {

                caso  1 :
                    dados_alunos . listar ();
                    pausa ;

                caso  2 :
                    dados_alunos . excluir_aluno ();
                    pausa ;

                caso  3 :
                    dados_alunos . incluir_aluno ();
                    pausa ;

                caso  4 :
                    dados_alunos . editar_notas ();
                    pausa ;
                caso  5 :
                    dados_alunos . editar_faltas ();
                    pausa ;
                caso  6 :
                    Console . WriteLine ( " Fechar programa " );
                    pausa ;
            }




                    Console . WriteLine ( " Nossa aulinha " );

Console . BackgroundColor  =  ConsoleColor . Preto ;
Console . WriteLine ( " Selecione a opção desejada " );
Console . WriteLine ( " 1- Lista de alunos " );
Console . WriteLine ( " 2-Excluir aluno " );
Console . WriteLine ( " 3-Incluir aluno " );
Console . WriteLine ( " 4- Editar notas " );
Console . WriteLine ( " 5-Editar faltas " );
Console . WriteLine ( " 6- sair " );


     boll  disse_certo  =  falso ;
       Faz
                {
                    registro_certo  =  int . TryParse ( Console . ReadLine (), out  opcao_menu );
                    if ( opcao_menu  <  1  ||  opcao_menu  >  6  ||  diz_certo  =  =  falso )
                {

                        Console . BackgroundColor  =  ConsoleColor . Vermelho ;
                        Console . WriteLine ( " Por favor, digite uma opção válida! " );
                        Console . BackgroundColor  =  ConsoleColor . Preto ;

                        registro_certo  =  falso ;
                    }
                } enquanto ( ! recuper_certo );
