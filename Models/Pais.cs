public class Pais{ //public porque se puede acceder desde otro model, por ejemplo
    public string Nombre{get;private set;} //get desde afuera lo puede leer cualquiera, pero private set porque solo se puede agregarle un valor desde esta clase
    public string imgBandera {get;private set;}
    public int Poblacion {get;private set;}
    public DateTime FechaIndependencia {get;private set;}
    public string AtractivosTuristicos {get;private set;}
    //como hay muchos objetos pais, no es una clase estatica
    public Pais(){
        
    }
    //siempre hay que crear un constructor vacio porque hay veces que creamos un objeto pero todavia no tiene valores
    public Pais(string Nom, string Img, int Pob, DateTime FInd, string AT){
        Nombre=Nom;
        imgBandera=Img;
        Poblacion=Pob;
        FechaIndependencia=FInd;
        AtractivosTuristicos=AT;
    }
    //como los atributos se pueden llenar solo desde aca adentro, hay que crear un constructor para que cuando el usuario crea un objeto, me va a mandar la informacion que necesite por parametro y desde aca adentro yo voy a llenar los atributos con los parametros
}