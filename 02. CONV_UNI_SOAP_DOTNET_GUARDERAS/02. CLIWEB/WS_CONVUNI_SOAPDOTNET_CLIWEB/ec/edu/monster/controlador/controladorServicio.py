from ec.edu.monster.modelo.modelo import ConvUniModelo

class ControladorServicio:
    
    def __init__(self):
        self.modelo = ConvUniModelo()
    
    def convCF(self,c):
        f = self.modelo.convCF(c)
        return f
    
    def convFC(self,f):
        c = self.modelo.convFC(f)
        return c