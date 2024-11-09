var n="victor";
var a=180;
var c=n+" "+a;

// metodo1 concatenar
var c1="<h1>hola</h1><h2>mi nombre es "+n+"</h2>";

/*
metodo2  template o plantillas de cadenas:
comilla invertida para crear templete una cadena en varias lineas
y ${} para reemplazo de variables
html no lo necesia es por claridad del codigo
https://developer.mozilla.org/es/docs/Web/JavaScript/Reference/Template_literals
*/
var c2=`
<h1>hola</h1>
<h2>mi nombre es ${n}</h2>
<h2>mido ${a}</h2>
`;

// metodo tres romper una linea de código
var c3="<h1>hola</h1> \
<h2>mi nombre es "+n+"</h2>";

var ele=document.getElementById("datos");
ele.innerHTML=c2;

if ( a>=190 ){
	ele.innerHTML='<h1>eres alto</h1>';
}else{
	ele.innerHTML='<h1>eres bajito</h1>';
}



showName(23,'rosa');
showDatos();

var datos=['a','b','c'];
alert(datos[0]);
alert(datos+' : '+datos[0]);

for (i=0;i<datos.length;i++){
	document.write(i);
}

document.write('<h1>Listado de nombres</h1>');
for (i=0;i<datos.length;i++){
	document.write(i+'<br/>');
}

document.write('<h1>Listado de datos</h1>');
var datos=['a1','b1','c1'];
datos.forEach(function(nombre){
	document.write(nombre+'<br/>');
})

// usar arrow tienes otra implicaciones que veremos en el curso
document.write('<h1>Listado de datos 2</h1>');
var datos=['a1','b1','c1'];
datos.forEach((nombre)=>{
	document.write(nombre+'<br/>');
})

document.write('<h1>Listado de años</h1>');
for( var i=2000;i<=2012;i++ ){
	ele.innerHTML += "año "+i+" ";
}

for( var i=2000;i<=2008;i++ ){
	ele.innerHTML += "año "+i+"<br/>";
}

function showName (a,b){
	var ele=document.getElementById("datos");
	ele.innerHTML='altura: '+a+' ; nombre: '+b+' ';
}

function getDatos(a,b){
	var d='altura: '+a+' ; nombre: '+b+' ';
	return d;
}

function showDatos(){
	var ele=document.getElementById("datos");
	ele.innerHTML=getDatos(24,'rosa');
}
