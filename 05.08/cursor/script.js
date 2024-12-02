
function sobre(a){
	document.getElementById('caja').innerHTML=a.innerHTML;
	// este codigo se podria meter en el evento de html pero generamos mas codigo
}
/* copiadas a php
function pinta(N,M){
// escribe asi tus comentarios
	var cadena= "<textarea id='caja'>HOLA</textarea><br/><br/>";
	if (M>16){M=16;}
	for(var i=0; i<N; i++){
		for(var j=0; j<M; j++){
			var id = "b"+ i + j;
			var nombreBoton= i.toString() + j.toString();
			cadena += "<button id='"+ id +"' onmouseover='sobre(this.innerHTML)'>"+ nombreBoton +"</button>";
		}
		cadena += "<br />"
	}

	return cadena;
}
*/

/*
function colores(){
	var lista=document.getElementsByTagName('button');
	for(var i=0; i<lista.length; i++){
		var clase='impar';if (i%2==0){clase='par';}
		lista[i].className=clase;
	}		
}
*/
