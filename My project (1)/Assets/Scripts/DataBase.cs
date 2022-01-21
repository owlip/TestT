using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataBase : MonoBehaviour
{
    [SerializeField] public List<Car> _Car;

    public string PrintCar(int i){
        return $"Масса:{_Car[i].Mass} кг\nMаксимальная скорость:{_Car[i].MaxSpeed} км/ч\nМарка:{_Car[i].Brand}\nСтрана:{_Car[i].Country}\nОбъем:{_Car[i].Value} л\nКласс:{_Car[i].Class_auto}\n{_Car[i].Colour}\nПривод:{_Car[i].DriveUnit}";
    }

    
    [SerializeField] public List<Ship> _Ship;
    public string PrintShip(int i){
        return $"Масса:{_Ship[i].Mass} тонн\nMаксимальная скорость:{_Ship[i].MaxSpeed} узлов\nМарка:{_Ship[i].Brand}\nСтрана:{_Ship[i].Country}\nВместимость:{_Ship[i].Capacity} человек\nВодоизмещение:{_Ship[i].Displacement} тонн\nДлина:{_Ship[i].Lenght} м";
    }
    
    [SerializeField] public List<Plane> _Plane;
    public string PrintPlane(int i){
        return $"Масса:{_Plane[i].Mass} кг\nMаксимальная скорость:{_Plane[i].MaxSpeed}км/ч\nМарка:{_Plane[i].Brand}\nСтрана:{_Plane[i].Country}\nВместимость:{_Plane[i].Capacity} человек\nГрузоподъемность:{_Plane[i].LoadCapacity}\nТип самолета:{_Plane[i].Type_plane}\nМаксимальная дистанция полета:{_Plane[i].MaxDistance}";
    }

    

}
