class Program
    {
        static int art�s = 0;

        static void Main(string[] args)
        {

            int[,] matris = {
                  { 1, 1,1, 1,1,1} ,
                  { 1, 2,2, 2,2,1} ,
                  { 1, 2,3, 3,2,1} ,
                  { 1, 2,3, 3,2,1} ,
                  { 1, 2,2, 2,2,1} ,
                  { 1, 1,1, 1,1,1} ,
                };
            string  sss =yazd�r(0, matris, "");
            Console.WriteLine(sss);

        }


        static string yazd�r(int art�s, int[,] dizi, string s){  
        
            int diziLengt = dizi.GetLength(0);
            Int32 diziMaxIndex = diziLengt - 1;
            
	    #region �st
            int ustsbt = art�s;
            for (int i = (art�s); i < diziLengt - art�s; i++)
            {
                s += dizi[ustsbt, i].ToString() + "-";
            }
            #endregion end�st

            #region sagyan
            int sagyansbt = diziMaxIndex - art�s;
            for (int i = (1 + art�s); i < diziLengt - art�s; i++)
            {
                s += dizi[i, sagyansbt].ToString() + "-";
            }
            #endregion sagyan

            #region alt
            int altsbt = diziMaxIndex - art�s;
            for (int i = diziMaxIndex - art�s; art�s < i; i--)
            {
                s += dizi[altsbt, i].ToString() + "-";
            }
            #endregion alt

            #region solyan
            int solsbt = art�s;
            for (int i = diziMaxIndex - art�s - 1; art�s < i; i--)
            {
                s += dizi[i, solsbt].ToString() + "-";
            }
            #endregion solyan

            if (diziLengt / 2 <= art�s++)
            {
                return s;
            }

            return yazd�r(art�s, dizi, s);
	
	}
    }

 

 

    }