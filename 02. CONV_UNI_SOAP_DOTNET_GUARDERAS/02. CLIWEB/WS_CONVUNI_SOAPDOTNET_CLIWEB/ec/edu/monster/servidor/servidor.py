from flask import Flask, render_template,request,jsonify,session,redirect,url_for

from ec.edu.monster.controlador.controladorServicio import ControladorServicio
from ec.edu.monster.controlador.controladorLogin import ControladorLogin


app = Flask(__name__, template_folder="../vista",static_folder="../vista/static")
app.secret_key = 'monster'
controladorServicio = ControladorServicio()

def login_required(f):
    def wrap(*args,**kwargs):
        if 'usuario' not in session:
            return redirect(url_for('login'))
        return f(*args,**kwargs)
    wrap.__name__ = f.__name__
    return wrap

@app.route('/')
@login_required
def home():
    return render_template('index.html')

@app.route('/login',methods=['GET','POST'])
def login():
    controlLogin = ControladorLogin()
    if request.method == 'POST':
        datos = request.get_json()
        usuario = datos.get('usuario')
        clave = datos.get('clave')
        
        if controlLogin.verifUsuario(usuario,clave):
            session['usuario'] = usuario
            return jsonify({"exito":True,"redirect": url_for('home')})
        else:
            return jsonify({"exito":False,"error":"Credenciales incorrectas"})
    return render_template('login.html')

@app.route('/convertir/c-f', methods=['POST'])
@login_required
def convertCF():
    datos = request.get_json()
    c = datos.get('c')
    if c is None:
        return jsonify({'error': 'Falta el valor de grados Celsius.'}), 400
    f = controladorServicio.convCF(c)
    return jsonify({'farenheit': f})

@app.route('/convertir/f-c', methods=['POST'])
@login_required
def convertFC():
    datos = request.get_json()
    f = datos.get('f')
    if f is None:
        return jsonify({'error': 'Falta el valor de grados Farenheit.'}), 400
    c = controladorServicio.convFC(f)
    return jsonify({'celsius': c})

@app.route('/logout')
def logout():
    session.pop('usuario',None)
    return jsonify({"redirect": url_for('login')})

if __name__ == '__main__':
    app.run(debug=True, host="0.0.0.0", port=8000)