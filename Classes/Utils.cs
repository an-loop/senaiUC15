namespace UC_15_SENAI.cl{
    
    public static class Utils{

        public static void LoadingScreen(string text, int tempo, int quantidade){
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;

            for (var contador = 0; contador < quantidade; contador++){
                Console.WriteLine(".");
                Thread.Sleep(tempo);
            }

            Console.ResetColor();
            Console.Clear();

        }

        public static void VerifyPath(string caminho){

            string pasta = caminho.Split("/")[0];

            if (!Directory.Exists(pasta)){
                Directory.CreateDirectory(pasta);
            }

            if (!File.Exists(caminho)){
                File.Create(caminho);
            }
        }
    }
}