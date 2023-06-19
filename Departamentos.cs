namespace Departamentos 
{
    //CLASE QUE DEFINE UN DEPARTAMENTO CON SU NOMBRE Y POBLACION 
    public class depto
    {
        public string Name {get; set;}
        public int Population {get; set;}

        public depto(String n, int poblacion){
            Name = n;
            Population = poblacion;
        }
    
    }
}