namespace patterns.Builder {
  interface Builder {
    AddTipProtector(): Builder;
    AddEdges(): Builder;
    AddBindings(): Builder;
    AddBreaks(): Builder;
  }

  class Ski {
    public parts: string[] = [];

    public listParts(): void {
      console.log(`Product parts: ${this.parts.join(", ")}\n`);
    }
  }

  class SkiBuilder implements Builder {
    private _finalProduct: Ski;

    constructor() {
      this.reset();
    }

    AddTipProtector(): SkiBuilder {
      this._finalProduct.parts.push("Tip Protector");
      return this;
    }
    AddEdges(): SkiBuilder {
      this._finalProduct.parts.push("Edges");
      return this;
    }
    AddBindings(): SkiBuilder {
      this._finalProduct.parts.push("Bindings");
      return this;
    }
    AddBreaks(): SkiBuilder {
      this._finalProduct.parts.push("Breaks");
      return this;
    }

    public GetInstance(): Ski {
      let result = this._finalProduct;
      this.reset();
      return result;
    }

    private reset(): void {
      this._finalProduct = new Ski();
    }
  }

  function Client(): void {
    let skiBuilder = new SkiBuilder();
    let concreteSki: Ski = skiBuilder.AddBindings().AddBreaks().GetInstance();
  }
}
