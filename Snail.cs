class Program
    {
        static int artýs = 0;

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
            string  sss =yazdýr(0, matris, "");
            Console.WriteLine(sss);

        }


        static string yazdýr(int artýs, int[,] dizi, string s){  
        
            int diziLengt = dizi.GetLength(0);
            Int32 diziMaxIndex = diziLengt - 1;
            
	    #region üst
            int ustsbt = artýs;
            for (int i = (artýs); i < diziLengt - artýs; i++)
            {
                s += dizi[ustsbt, i].ToString() + "-";
            }
            #endregion endüst

            #region sagyan
            int sagyansbt = diziMaxIndex - artýs;
            for (int i = (1 + artýs); i < diziLengt - artýs; i++)
            {
                s += dizi[i, sagyansbt].ToString() + "-";
            }
            #endregion sagyan

            #region alt
            int altsbt = diziMaxIndex - artýs;
            for (int i = diziMaxIndex - artýs; artýs < i; i--)
            {
                s += dizi[altsbt, i].ToString() + "-";
            }
            #endregion alt

            #region solyan
            int solsbt = artýs;
            for (int i = diziMaxIndex - artýs - 1; artýs < i; i--)
            {
                s += dizi[i, solsbt].ToString() + "-";
            }
            #endregion solyan

            if (diziLengt / 2 <= artýs++)
            {
                return s;
            }

            return yazdýr(artýs, dizi, s);
	
	}
    }

 

 

    }