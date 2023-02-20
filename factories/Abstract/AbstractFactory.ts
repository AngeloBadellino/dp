interface IButton {}
interface ILabel {}

class BlueButton implements IButton { }
class GreenButton implements IButton { }

class BlueLabel implements ILabel { }
class GreenILabel implements ILabel { }

interface IComponentAbstractFacroty {
    GetButton() : IButton;
    GetLabel() : IButton;
}

class BluComponentAbstractFactory implements IComponentAbstractFacroty{
    GetButton(): IButton {
        return new BlueButton();
    }
    GetLabel(): IButton {
        return new GreenButton();
    }
}