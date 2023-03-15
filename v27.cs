namespace v27
{

    interface Hitung{

        void judul(string j);

        int kali(int a, int b);

        int tambah(int a, int b);
    }

    class Calculator:Hitung
    {

        public void judul(string j){
            Console.WriteLine(j);
        }

        public int kali(int a, int b){
            return a * b;
        }

        public int tambah(int a, int b){
           return a + b; 
        }
    }
}