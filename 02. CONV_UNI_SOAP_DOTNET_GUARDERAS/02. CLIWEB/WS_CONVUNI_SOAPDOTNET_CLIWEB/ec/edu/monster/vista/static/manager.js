
async function convertCF(){
    const c = document.getElementById('cIn').value;
    if(c!== undefined && c !==''){
        console.log(c+"°C")
        const respuesta = await fetch('/convertir/c-f',{
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify({c: parseFloat(c)})
        });
        const datos = await respuesta.json();
        console.log(datos.farenheit+"°F")
        document.getElementById('fOut').value = respuesta.ok ?
            datos.farenheit : '';
    }
    else{
        document.getElementById('cIn').value = '';
        document.getElementById('fOut').value = '';
    }
}

async function convertFC(){
    const f = document.getElementById('fIn').value;
    if(f!== undefined && f !==''){
        console.log(f+"°F")
        const respuesta = await fetch('/convertir/f-c', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify({f: parseFloat(f)})
        });
        const datos = await respuesta.json();
        console.log(datos.celsius+"°C")
        document.getElementById('cOut').value = respuesta.ok ?
            datos.celsius : '';
    }
    else{
        document.getElementById('fIn').value = '';
        document.getElementById('cOut').value = '';
    }
}