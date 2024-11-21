from zeep import Client


class ConvUniModelo:
    
    def __init__(self):
        self.wsdl_url = 'http://127.0.0.1/CONVUNI/ec.edu.monster.servicios/CONVUNI.svc?wsdl'
        self.cliente = Client(wsdl=self.wsdl_url)

    def convCF(self,c):
        try:
            resultado = self.cliente.service.convertCF(c)
            return resultado
        except Exception as e:
            return -1

    def convFC(self,f):
        try:
            resultado = self.cliente.service.convertFC(f)
            return resultado
        except Exception as e:
            return -1

