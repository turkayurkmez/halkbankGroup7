namespace LooselyCoupled
{
    public class Insan
    {
        public void Giy(IKiyafet kiyafet)
        {

        }
    }

    public interface IKiyafet
    {

    }

    public class UstGiyim : IKiyafet
    {

    }


    public class Kazak : UstGiyim
    {

    }
    public class KirmiziKazak : Kazak
    {

    }


}
