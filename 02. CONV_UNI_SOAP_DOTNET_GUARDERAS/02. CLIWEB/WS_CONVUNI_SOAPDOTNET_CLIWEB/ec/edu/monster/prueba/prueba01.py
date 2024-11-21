from ec.edu.monster.controlador.controladorServicio import ControladorServicio

class Prueba01:
    
    def probar(self):
        c = 0
        f = 32
        
        conServicio = ControladorServicio()
        
        nuevF = conServicio.convCF(c)
        nuevC = conServicio.convFC(f)
        
        print(str(c)+"°C = "+str(nuevF)+"°F")
        print(str(f)+"°F = "+str(nuevC)+"°C")
        
        
if __name__ == "__main__":
    pr1 = Prueba01()
    pr1.probar()