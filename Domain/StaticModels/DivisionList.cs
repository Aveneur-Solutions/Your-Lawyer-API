namespace Domain.StaticModels
{
    public static class DivisionList
    {
        public static string[] Divisions = {"Dhaka","Chittagong","Rajhshahi","Comilla","Barisal","Sylhet","Rangpur","Khulna"};
        public static string getDivision(int index){
            return Divisions[index];
        }

        // Returns the index of the Division in the array if found else return -1 which is to be handled where the function is called 
        public static int getIndex(string division)
        {

           
            for(int i=0;i<Divisions.Length;i++)
            {
                if(Divisions[i].ToLower().Equals(division.ToLower())) return i;
            }
               
             return -1;  

        }
    }
}