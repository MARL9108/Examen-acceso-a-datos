# Examen-acceso-a-datos
2da parte de la prueba
# Ejercicio 1
La principal diferencia es que los objetos IQueryable<T> de LINQ usan expresiones en lugar de delegados.
IEnumerable<T> es útil para trabajar con secuencias que se iteran en la memoria pero IQueryable<T>; es ideal 
con fuentes de datos remotas como una base de datos o servicio web.
# Ejercicio 5
Connection: Proporciona conectividad a un origen de datos. 
Parameter: Describe un parámetro para un command.
Command: Permite tener acceso a comandos de base de datos para devolver datos,
modificarlos, ejecutar procedimientos almacenados y enviar o recuperar información sobre
parámetros. 
DataReader: Proporciona flujo de datos de alto rendimiento desde el origen de datos.
DataAdapter:Proporciona el puente entre el objeto DataSet y el origen de datos.
DataSet: Sirve para acceder a datos independientemente del origen de datos.
