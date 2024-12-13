public class Samling<T>{
  int buffert;
  T[] Listan;
  int längd;
  int antal;

  public Samling(){
    buffert = 30;
    T[] Listan = new T[längd];
    längd = 10;
    antal = 0;
  }

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
    längd = antal;
    Listan = temp;
  }

  public void LäggTill(T b){
    if (antal == längd){
      Expandera(1);
    }
    Listan[antal] = b;
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

    a.Print();
  }
}