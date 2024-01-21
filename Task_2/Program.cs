using Task_2;

Radius rad = new Radius();

Radius.Calculate calc = new Radius.Calculate(rad.CircleLength);
calc += rad.CircleSquare;
calc += rad.VolumeBall;
calc(10);