using System.Collections.Generic;

class Ski {

    List<string> components = new List<string>();

    public void Add(string component) => components.Add(component);
}

interface Builder {
    void AddTipProtector();
    void AddEdges();
    void AddBindings();
    void AddBreaks();
}

class SkiBuilder : Builder {
    private Ski _finalProduct = new Ski();
    public void AddTipProtector() => this._finalProduct.Add("Tip Protector");
    public void AddEdges() => this._finalProduct.Add("Edges");
    public void AddBindings() => this._finalProduct.Add("Bindings");
    public void AddBreaks() => this._finalProduct.Add("Breaks");
    public Ski GetInstance(){
        Ski instance = this._finalProduct;
        Reset();
        return instance;
    }
    private void Reset() => _finalProduct = new Ski();
}

class Client{
    SkiBuilder builder = new SkiBuilder();
    Ski newSki = builder.AddBreks().AddBindings().AddEdges().GetInstance();
}