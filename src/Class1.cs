namespace SonarDemo
{
    public class Class1
    {
        public bool function1(){
            var abc = "poor name variable";
            return (abc!=null);
        }
        public bool CanModBy3(int x){
            return (x % 3 ==0);
        }

        public void somefunction(){
            string s = "";
            try
            {
            s = File.ReadAllText("fileName");
            }
            catch (Exception e)  // Noncompliant
            {
                throw;
            }
        }
    }

}

