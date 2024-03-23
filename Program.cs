namespace tpmodul6_1302223027
{
    class Program
    {
        static void Main(String[] args)
        {
            SayaTubeVideo test = new SayaTubeVideo("Tutorial Design By Contract – Kevin Albany");

            test.IncreasePlayCount(10_000_001);

            for (int i = 0;i<214;i++) {
                test.IncreasePlayCount(10_000_000);
            }

            
            test.PrintVideoDetail();    
        }
    }
}