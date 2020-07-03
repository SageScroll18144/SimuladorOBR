# SimuladorOBR
OBR simulação. A cada "código" que escrevo tenho sdds do Arduino!


## Tradução das funções

- Print no terminal

```
escrever(1, "hi")
```

```cs
bc.printLCD(1, "hi");
```

- Retorna a cor lida pelo sensor

```
cor(2)
```

```cs
bc.returnColor(2);
```

- Move

```
mover(x, y)
```

```cs
bc.onTF((-60), 60);
```

- Delay

```
esperar(500)
```

```cs
bc.wait(500);
```