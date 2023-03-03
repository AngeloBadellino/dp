enum PrototypeEnum
{
    Board,
    Ski
}

class ProtoypeRegistry{
    private Prototype[] _prototypes;

    public ProtoypeRegistry(){
        this._prototypes = new Prototype[2]
        { 
            Board, 
            Ski
        };

    }

    public GetPrototype(PrototypeEnum index){
        return _prototypes[index];
    }
}

abstract class Prototype{
    public abstract Prototype Clone();
}

// Possibly having deep copy with full control over it initialization.
class Board : Prototype {
    public Prototype Clone() => this.MemberwiseClone();
}

class Ski : Prototype {
    public Prototype Clone() => this.MemberwiseClone();
}

class Client{

    public void Main(){
        var registry = new ProtoypeRegistry();
        var newBoard = registry.GetPrototype(PrototypeEnum.Board).Clone();
        var newSki = registry.GetPrototype(PrototypeEnum.Ski).Clone();
    }
}

