# IIPr1 - Introducción a C# en Unity

- **Ejercicio 1 — Cambio de color periódico:** El script `ColorChange` cambia el color del objeto usando un vector RGB inicial aleatorio y, cada `waitFrames` fotogramas, modifica al azar una componente (R, G o B). Parámetro visible en el Inspector: `waitFrames`.
	- Script: [scripts/ColorChange.cs](scripts/ColorChange.cs)
	- Gif de ejecución: ![Ejercicio 1](gifs/exercise1.gif)
- **Ejercicio 2 — Operaciones con vectores:** El script `Vectors` expone dos `Vector3` públicos (`vector1`, `vector2`) y calcula:
	- Magnitud de cada vector (`magnitude1`, `magnitude2`).
	- Ángulo entre ambos (`angle`).
	- Distancia (`distance`).
	- Qué vector está a mayor altura (`highestVector`).
	- Todos los resultados se muestran por consola y en el Inspector.
	- Script: [scripts/Vectors.cs](scripts/Vectors.cs)
	- Gif de ejecución: ![Ejercicio 2](gifs/exercise2.gif)
- **Ejercicio 3 — Posición de la esfera en pantalla:** El script `SpherePosition` dibuja en pantalla la posición actual del `Transform` de la esfera usando `OnGUI`.
	- Script: [scripts/SpherePosition.cs](scripts/SpherePosition.cs)
	- Gif de ejecución: ![Ejercicio 3](gifs/exercise3.gif)
- **Ejercicio 4 — Distancia entre objetos:** El script `DistanceFrom` busca los objetos por etiqueta (`Sphere`, `Cube`, `Cylinder`) y calcula la distancia entre la esfera y el cubo / cilindro, mostrando el resultado en consola cada vez que cambia alguna posición.
	- Script: [scripts/DistanceFrom.cs](scripts/DistanceFrom.cs)
	- Gif de ejecución: ![Ejercicio 4](gifs/exercise4.gif)