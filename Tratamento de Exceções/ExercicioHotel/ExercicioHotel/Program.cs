using ExercicioHotel.Entities;


//Solução ruim: Foi preciso colocar toda lógica no programa principal;
//Solução II ruim: Retorno de uma string;

Console.WriteLine("Room number: ");
int number = int.Parse(Console.ReadLine());

Console.WriteLine("Check-in date (dd/MM/yyyy): ");
DateTime checkIn = DateTime.Parse(Console.ReadLine());

Console.WriteLine("Check-out date (dd/MM/yyyy): ");
DateTime checkOut = DateTime.Parse(Console.ReadLine());


if (checkOut <= checkIn)
{
    Console.WriteLine("Error in reservation: Check-out date must be after check-in date.");
}

else
{
    Reservation reservation = new Reservation(number, checkIn, checkOut);
    Console.WriteLine("Reservation: " + reservation);

    Console.WriteLine();
    Console.WriteLine("Enter data to update the reservation: ");

    Console.WriteLine("Check-in date (dd/MM/yyyy): ");
    checkIn = DateTime.Parse(Console.ReadLine());

    Console.WriteLine("Check-out date (dd/MM/yyyy): ");
    checkOut = DateTime.Parse(Console.ReadLine());



    string error = reservation.UpdateDates(checkIn, checkOut);

    if (error != null)
    {
        Console.WriteLine("Error in Reservation: " + error);
    }

    else
    {
        Console.WriteLine("Reservation: " + reservation);
    }
}




