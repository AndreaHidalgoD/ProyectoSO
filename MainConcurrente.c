#include <string.h>
#include <unistd.h>
#include <stdlib.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <stdio.h>
#include <mysql.h>
#include <ctype.h>
#include <pthread.h>
void *AtenderCliente (void *socket)
{	//CONECTAR BASE DE DADES
	MYSQL *conn;
	int err;
	// Estructura especial para almacenar resultados de consultas 
	MYSQL_RES *resultado;
	MYSQL_ROW row;
	char consulta [80];
	//Creamos una conexion al servidor MYSQL 
	conn = mysql_init(NULL);
	if (conn==NULL) {
		printf ("Error al crear la conexion: %u %s\n", mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	//inicializar la conexion
	conn = mysql_real_connect (conn, "localhost","root", "mysql", "db",0, NULL, 0);
	if (conn==NULL) {
		printf ("Error al inicializar la conexion: %u %s\n", mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	
	
	int sock_conn;
	int *s;
	s= (int *) socket;
	sock_conn= *s;
	
	//int socket_conn = * (int *) socket;
	
	char peticion[512];
	char respuesta[512];
/*	char consulta [512];*/
	char nombre [20];
/*	int err;*/
	int ret;
/*	MYSQL_ROW row;*/
/*	MYSQL_RES *resultado;*/
/*	MYSQL *conn;*/
	
	int terminar =0;
	// Entramos en un bucle para atender todas las peticiones de este cliente
	//hasta que se desconecte
	
	// Entramos en un bucle para atender todas las peticiones de este cliente
	//hasta que se desconecte
	while (terminar ==0)
	{
		// Ahora recibimos la petici?n
		ret=read(sock_conn,peticion, sizeof(peticion));
		printf ("Recibido\n");
		
		// Tenemos que a?adirle la marca de fin de string 
		// para que no escriba lo que hay despues en el buffer
		peticion[ret]='\0';
		
		printf ("Peticion: %s\n",peticion);
		
		// vamos a ver que quieren
		char *p = strtok( peticion, "/");
		int codigo =  atoi (p);
		printf("numero de codigo %d\n",codigo);
		// Ya tenemos el c?digo de la petici?n
		char nombre[20];
		if (codigo !=0 && codigo!=3)
		{
			printf("entro codigo dif0\n");
			p = strtok( NULL, "/"); //segundo trozo
			strcpy (nombre, p);
			// Ya tenemos el nombre
			printf ("Codigo: %d, Nombre: %s\n", codigo, nombre);
		}
		if (codigo ==0) //petici?n de desconexi?n
			terminar=1;
		
		else if (codigo ==1)
		{
			// Consulta 1:
			// BUSCA LOS JUGADORES CON LOS QUE HA JUGADO LA PERSONA QUE INTRDUCES POR CONSOLA
			printf("entro en 1\n");
			
			strcpy(consulta,"SELECT DISTINCT JUGADOR.ID FROM(PARTIDA, JUGADOR, CONNECTOR) WHERE PARTIDA.ID IN (SELECT PARTIDA.ID FROM(PARTIDA, JUGADOR, CONNECTOR) WHERE JUGADOR.ID= '");
			strcat(consulta,nombre);
			strcat(consulta,"' AND JUGADOR.ID= CONNECTOR.ID_J AND CONNECTOR.ID_P=PARTIDA.ID) AND PARTIDA.ID= CONNECTOR.ID_P AND CONNECTOR.ID_J=JUGADOR.ID AND JUGADOR.ID NOT IN ('");
			strcat(consulta,nombre);
			strcat(consulta,"')"); 
			
			printf("%s\n",consulta);
			// Establece connexión con la base de datos
			err=mysql_query (conn, consulta); 
			if(err!=0){
				printf("Error al consultar datos de la base \u0153u \u0153s\n", mysql_errno(conn),mysql_error(conn));
				exit(1);
			}
			//Retorna resultados de la consulta
			resultado = mysql_store_result (conn);
			row = mysql_fetch_row (resultado);
			if (row == NULL)
			{
				row[0]='0';
				sprintf (respuesta, "%s" , row[0]);
			}
			else
			{
				sprintf (respuesta, "%s", row[0]);
				printf("Entra al i=0\n");
				row = mysql_fetch_row (resultado);
				while (row!=NULL)
				{
					sprintf (respuesta, "%s,%s", respuesta, row[0]); //Encadenamos la respuesta ya que puede haber jugado con mas de una persona
					row = mysql_fetch_row (resultado);
				}
			}
			printf("%s\n",respuesta);
		}
		
		else if (codigo ==2) 
		{
			// Consula 2
			// BUSCA QUE JUGADOR QUE HA JUGADO EN LA PARTIDA INTRODUCIDA POR CONSOLA TIENE MAS PUNTOS ACUMULADOS
			printf("entro codigo2\n");
			
			strcpy(consulta,"SELECT DISTINCT JUGADOR.ID FROM(JUGADOR,CONNECTOR,PARTIDA) WHERE JUGADOR.TOTALPUNTS = (SELECT DISTINCT MAX(JUGADOR.TOTALPUNTS) FROM(JUGADOR, PARTIDA, CONNECTOR) WHERE CONNECTOR.ID_P = ");
			strcat(consulta,nombre);
			strcat(consulta," AND CONNECTOR.ID_J =JUGADOR.ID) AND JUGADOR.ID = CONNECTOR.ID_J AND CONNECTOR.ID_P = ");
			strcat(consulta,nombre);
			
			printf("%s\n",consulta);
			// Establece connexión con la base de datos
			err=mysql_query (conn, consulta); 
			if(err!=0){
				printf("Error al consultar datos de la base \u0153u \u0153s\n", mysql_errno(conn),mysql_error(conn));
				exit(1);
			}
			//Retorna resultados de la consulta
			resultado = mysql_store_result (conn);
			row = mysql_fetch_row (resultado);
			if (row == NULL)
			{
				printf("row null\n");
				row[0]='0';
				sprintf (respuesta, "%s" , row[0]);
			}
			else 
			{
				printf("todo ok\n");
				sprintf (respuesta, "%s", row[0]);
			}
		}
		else if (codigo ==3)
		{
			// Consulta 3
			// BUSCA LA PARTIDA MÁS CORTA Y QUE SU TIEMPO ES INFERIOR A 1500s
			printf("entro bien");
			strcpy (consulta,"SELECT PARTIDA.ID FROM(PARTIDA) WHERE PARTIDA.TEMPS =(SELECT MIN(PARTIDA.TEMPS) FROM PARTIDA) AND PARTIDA.TEMPS < 1500"); 
			
			// hacemos la consulta 
			err=mysql_query (conn, consulta); 
			if (err!=0) {
				printf ("Error al consultar datos de la base %u %s\n",
						mysql_errno(conn), mysql_error(conn));
				exit (1);
			}
			//recogemos el resultado de la consulta 
			resultado = mysql_store_result (conn); 
			row = mysql_fetch_row (resultado);
			if (row == NULL){
				sprintf (respuesta,"No se han obtenido datos en la consulta");
				printf ("No se han obtenido datos en la consulta\n");
			}
			else{
				// El resultado debe ser una matriz con una sola fila
				// y una columna que contiene el nombre
				sprintf (respuesta,"ID de la partida mas corta: %s", row[0] );
				printf ("ID de la partida mas corta: %s\n", row[0] );
			}
		}
		
		else if (codigo==4) 
			// LOG IN
			// NOS PERMITE COMPROBAR SI EL USUARIO Y LA CONTRASEÑA INTRODUCIDOS EXISTEN EN LA BASE DE DATOS, EN CASO CONTRARIO NOS AVISA
		{
			p = strtok( NULL, "/"); //Cogemos contraseña
			char contrasenya [20];
			strcpy (contrasenya, p);
			printf("%s\n",nombre);
			printf("%s\n",contrasenya);
			//strcpy(consulta,"SELECT JUGADOR.CONTRASENYA FROM (JUGADOR) WHERE JUGADOR.ID ='");
			//strcat(consulta,nombre);
			//strcat(consulta,"'");
			sprintf(consulta, "SELECT JUGADOR.CONTRASENYA FROM (JUGADOR) WHERE JUGADOR.ID ='%s'",nombre);
			printf("%s\n", consulta);
			//Realizamos la consulta
			err=mysql_query (conn, consulta); 
			if (err!=0) {
				printf ("Error al consultar datos de la base %u %s\n",
						mysql_errno(conn), mysql_error(conn));
				exit (1);
			}
			//recogemos el resultado de la consulta 
			resultado = mysql_store_result (conn); 
			row = mysql_fetch_row (resultado);
			printf(row[0]);
			if (row == NULL){
				sprintf (respuesta,"NO EXISTE"); //El usuario introducido no existe en la base de datos
				printf ("No se han obtenido datos en la consulta\n");
			}
			else{
				// El resultado debe ser una matriz con una sola fila
				// y una columna que contiene el nombre
				if (strcmp(row[0],contrasenya)==0)
				{
					sprintf (respuesta,"OK"); //El usuario es identificado en la base de datos
					printf ("OK\n");
				}
				else{
					sprintf (respuesta,"INCORRECTA"); //Existe el usuario introducido pero la contraseña proporcionada es incorrecta
					printf ("CONTRASENYA INCORRECTA\n");
				}
			}
		}
		
		else if (codigo==5) //SIGN IN
		{
			p = strtok( NULL, "/"); //Cogemos contraseña
			char contrasenya [20];
			strcpy (contrasenya, p);
			strcpy(consulta,"SELECT JUGADOR.CONTRASENYA FROM (JUGADOR) WHERE JUGADOR.ID = '");
			strcat(consulta,nombre);
			strcat(consulta,"'");
			printf("%s\n",consulta);
			
			//Realizamos la consulta
			err=mysql_query (conn, consulta); 
			if (err!=0) {
				printf ("Error al consultar datos de la base %u %s\n",
						mysql_errno(conn), mysql_error(conn));
				exit (1);
			}
			//recogemos el resultado de la consulta 
			resultado = mysql_store_result (conn); 
			row = mysql_fetch_row (resultado);
			
			if (row == NULL){ //Si el usuario no existe procederá a registrarlo
				char consulta2 [1000];
				strcpy(consulta2,"INSERT INTO JUGADOR VALUES ('");
				strcat(consulta2,nombre);
				strcat(consulta2,"','");
				strcat(consulta2,contrasenya);
				strcat(consulta2,"',0)");
				printf("%s\n",consulta2);
				err=mysql_query (conn, consulta2); 
				if (err!=0) {
					sprintf(respuesta,"ERROR");
					printf ("Error al introducir los datos de la base %u %s\n",
							mysql_errno(conn), mysql_error(conn));
					exit (1);
				}
				//recogemos el resultado de la consulta 
				else{
					sprintf (respuesta,"OK"); //Hemos podido añadir correctamente el usuario en la base de datos
					printf ("OK\n");
				}
			}
			else{
				sprintf (respuesta,"YA EXISTE"); //El usuario introducido ya existe en la base de datos, por lo tanto no lo añadimos
				printf ("YA EXISTE EL USUARIO\n");
			}
		}
		
		if (codigo != 0)
		{
			//Envia el mensaje a mi consola en C#
			printf ("Respuesta: %s\n", respuesta);
			// Y lo enviamos
			write (sock_conn,respuesta, strlen(respuesta));// socket de conexion, respuesta, longitud de la respuesta
		}
	}
	close(sock_conn);
}
int main (int argc, char *argv[]) 
{
	
	//CONECTAR BASE DE DADES
/*	MYSQL *conn;*/
/*	int err;*/
	// Estructura especial para almacenar resultados de consultas 
/*	MYSQL_RES *resultado;*/
/*	MYSQL_ROW row;*/
/*	char consulta [80];*/
	//Creamos una conexion al servidor MYSQL 
/*	conn = mysql_init(NULL);*/
/*	if (conn==NULL) {*/
/*		printf ("Error al crear la conexion: %u %s\n", mysql_errno(conn), mysql_error(conn));*/
/*		exit (1);*/
/*	}*/
	//inicializar la conexion
/*	conn = mysql_real_connect (conn, "localhost","root", "mysql", "db",0, NULL, 0);*/
/*	if (conn==NULL) {*/
/*		printf ("Error al inicializar la conexion: %u %s\n", mysql_errno(conn), mysql_error(conn));*/
/*		exit (1);*/
/*	}*/
	
	
	// CONECTAR SERVIDOR-CLIENT
	int sock_conn, sock_listen, ret;
	struct sockaddr_in serv_adr;
	char peticion[512]; //peticion buff
	char respuesta[512]; //respuesta buff2
	// INICIALITZACIONS
	// Obrim el socket
	if ((sock_listen = socket(AF_INET, SOCK_STREAM, 0)) < 0) //crear socket de escucha
		printf("Error creant socket");
	// Fem el bind al port
	
	
	memset(&serv_adr, 0, sizeof(serv_adr));// inicialitza a zero serv_addr
	serv_adr.sin_family = AF_INET;
	
	// asocia el socket a cualquiera de las IP de la m?quina. 
	//htonl formatea el numero que recibe al formato necesario
	serv_adr.sin_addr.s_addr = htonl(INADDR_ANY); //indicamos a cualquier
	// escucharemos en el port 9200
	serv_adr.sin_port = htons(9270); 
	if (bind(sock_listen, (struct sockaddr *) &serv_adr, sizeof(serv_adr)) < 0) //asociamos al socket las esecificaciones anteriores
		printf ("Error al bind\n");
	//La cola de peticiones pendientes no podr? ser superior a 4
	if (listen(sock_listen, 2) < 0) //lo ponemos en pasivo. EL 2 es el numero de objetos en cola
		printf("Error en el Listen");
	
	int i;
	int sockets[100];
	pthread_t thread;
	i=0;
	// Bucle infinito
	for (;;){
		printf ("Escuchando\n");
		
		sock_conn = accept(sock_listen, NULL, NULL);
		printf ("He recibido conexion\n");
		//sock_conn es el socket que usaremos para este cliente
		
		sockets[i] =sock_conn;
		//sock_conn es el socket que usaremos para este cliente
		
		// Crear thead y decirle lo que tiene que hacer
		
		pthread_create (&thread, NULL, AtenderCliente,&sockets[i]);
		i=i+1;
		
		}
		// Se acabo el servicio para este cliente
		//close(sock_conn); 
		//mysql_close(conn); //Cerramos la base de datos
		//exit(0);
}

