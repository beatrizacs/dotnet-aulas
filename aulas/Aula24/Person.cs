namespace Aula24
{
    public class Person
    {
        //1. Atributos
        public string Name;
        public int Age;
        public int peso;

        //2. Métodos
        public bool IfLegalPerson(int Age)
        {
            if (Age>= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //3. Refatorar
        public string IfLegalPersonRefactor(int Age, string Name)
        {
            string result = string.Empty;
            var agevalid = IfLegalPerson(Age);

            if(agevalid)
            {
                result = "\nA/O " + Name +  " é maior de idade!";
                return result;
            }
            else
            {
                result = "A/O "+ Name +" é menor de idade";
                return result;
            }
        }

    }
}