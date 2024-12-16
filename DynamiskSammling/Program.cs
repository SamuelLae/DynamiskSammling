public class Samling<T>{

  /// <summary>
  ///  Buffertens storlek
  /// </summary>
  int buffert;
  T[] Listan;
  /// <summary>
  /// Antal tillgängliga platser
  /// </summary>
  int längd;
  int antal;

  public Samling(){
    buffert = 30;
    längd = 10;
    antal = 0;
    Listan = new T[längd];
  }


  /// <summary>
  /// Utökar antalet till längden i listan
  /// </summary>
  /// <param name="storlek">Storleken på listan</param>
  public void Expandera(int storlek){
    if (storlek < 1){
      return;
    }

    T[] temp = new T[längd + storlek];

    for (int i = 0; i < antal; i++)
    {
      temp[i] = Listan[i];
    }

    Listan = temp;
  }

  public void Reducera(){

    T[] temp = new T[antal];

    for (int i = 0; i < antal; i++)
    {
      temp[i] = Listan[i];
    }
     Listan = temp;
    längd = antal;
   
  }

  public void LäggTill(T b){
    if (antal <= längd){
      Expandera(1);
    }
    Listan[antal] = b;
    antal++;
  }

  public void TaBort(int c){
  if (antal < längd || c >= 0 || c >= antal){

    T[] temp = new T[längd];
    int tempIndex = 0;

    for (int i = 0; i < antal; i++) {
        if (i != c) {
            temp[tempIndex] = Listan[i];
            tempIndex++;
        }
    }

    Listan = temp;

    antal--;
    }
  }

   public void Print(){
     for (int i = 0; i < antal; i++)
    {
      Console.WriteLine(Listan[i]);
    }
  }
}

class Program{
  static void Main(){
  Samling<bool> a = new Samling<bool>();
    a.LäggTill(true);

    a.LäggTill(false);

    a.Reducera();

    a.TaBort(3);
    a.Print();
  }
}