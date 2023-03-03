namespace patterns.Prototype {
  class Ski {
    public Brand: any;
    public Bindings: object;
    public CurrentSkier: Skier;
  }

  class Skier {
    private _ski: Ski;

    constructor(ski: Ski) {
      this._ski = ski;
    }
  }
}
