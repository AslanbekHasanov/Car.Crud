# Car.Crud
We can see CRUD operations using OOP principles in this repository. In the program, the code belonging to the rules of Meyor is written.

![Diagram Project](/Images/diagram-project.png)

## 1 Broker
### 1.0 Enter
The necessary files and classes are created in the broker file. 
$$$$$$$$$$$$


### 1.1 File.Broker

Let me tell you a little bit about this project. There are 2 classes inside ```File.Broker```
* FileStorageBroker
* IFileStorageBroker

#### 1.1.1 FileStorageBroker.cs
Inside this class:
* ReadAllCar
* ReadCar
* AddCar
* DeleteCar
* UpdateCar
#### 1.1.2 IFileStorageBroker.cs
$$$$$$$
The main part of the methods needed by this interface class is written, and the main part is written as a successor to ```FileStorageBroker.cs```

### 1.2 LoggingBroker
Let me give you a brief overview of this project. There are 2 classes inside ```LoggingBroker``` and this file shows us the errors we can get.
* ILogingBroker
* LogingBroker

#### 1.2.1 ILogingBroker
The main part is written in this class and the rest is written inside the ```LogingBroker``` class.
$$$$$$$$$

#### 1.2.2 LoggingBroker
In this class, we inherit from ````ILogingBroker```` and write the body code here.
$$$$$$

### 1.3 DTO
A txt file is created in the ```DTO``` file and the necessary information is written through this txt file.
### 1.4 Model And Cars
A file called ```Cars``` is created inside the model file. Inside the ```Cars``` file, a class called ```Acar``` is created, and all properties related to the car are created in this class.
$$$$$$
#### 1.3.1 ACar.cs
```
	public int Id { get; set; }
	
	public string Name { get; set; }

	public string Color { get; set; }

	public string Number { get; set; }
```

### 1.5 Service and CarService
Inside the ```Service``` file, a File called ```CarService``` is created and inside this ```CarService``` file there are 2 classes.This file records errors that occur in the ```Console```
* ICarService
* CarService

#### 1.5.1 ICarService.cs
In this class, the head part of the code is written and the rest of the body is written to CarService by implicating it to``` CarServices```
```
	List<ACar> ReadALlCars();
        ACar ReadCar(int id);
        ACar AddCar(ACar car);
        bool DeleteACar(string number);
        bool Update(ACar car);
```
#### 1.5.2 CarService.cs
In this class, we record the errors that occur in the console. For example, the number was not found, there was an error in giving the numbers.