class Singleton{

    private static Singleton _instance;

    private int _state;

    private void Singleton(){

    }

    public static Singleton GetInstance(){
        if (_instance == null) _instance = new Singleton();

        return _instance;
    }

    public void GetState(){
        return ++_state;
    }
}

class SingletonCient {

    public void Main(){
        Singleton s1 = Singleton.GetInstance();
        Singleton s2 = Singleton.GetInstance();

        int a = s1.GetState(); // 1
        int b = s2.GetState(); // 2
        int c = s1.GetState(); // 3
        int d = s2.GetState(); // 4
    }
}