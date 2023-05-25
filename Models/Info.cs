public static class Info{
    private static List<Pais> ListaPaises=new List<Pais>();
    private static void InicializarLista(){ //void porque solo llena la lista
        Pais unPais=new Pais("Argentina", "argentina.jpg", 45000000, new DateTime(1816,7,9), "Cataratas"); //estos son los parametros nom, img, pob, etc 
        ListaPaises.Add(unPais);
        unPais=new Pais("Brasil", "brasil.JPG", 145000000, new DateTime(1816,7,10), "Amazonas");
        ListaPaises.Add(unPais);
        unPais=new Pais("Chile", "chile.png", 25000000, new DateTime(1816,7,11), "Pucon");
        ListaPaises.Add(unPais);
        unPais=new Pais("Uruguay", "uruguay.png", 15000000, new DateTime(1816,7,12), "Punta del Este");
        ListaPaises.Add(unPais);
        unPais=new Pais("Paraguay", "paraguay.png", 35000000, new DateTime(1816,7,13), "Asuncion");
        ListaPaises.Add(unPais);
    }
    public static List<Pais> ListarPaises(){
        if (ListaPaises.Count==0){//.count es como .length de vectores pero para listas
            InicializarLista();
        }
        return ListaPaises;
    }
    public static Pais DetallePais(string Nombre){
        Pais PaisBuscado = new Pais();
        foreach(Pais item in ListaPaises){
            if (item.Nombre == Nombre){
                return item;
            }
        }
        return PaisBuscado; //cuando no encuentra el pais en la lista, devuelve el pais buscado que esta vacio
    }
}