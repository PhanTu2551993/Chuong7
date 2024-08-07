using System.Runtime.InteropServices;

namespace Chuong7_lythuyet
{

    public interface IEntity
    {
        string ID { get; set; }
    }

    public class Employee : IEntity
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Employee(string id, string name, int age)
        {
            ID = id;
            Name = name;
            Age = age;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"ID: {ID}, Name: {Name}, Age: {Age}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //1) So sánh giữa lớp và interface ?

            /*
             1. Định nghĩa :

                    Lớp (class) : Là một bản thiết kế cho việc tạo ra các đối tượng (object).
                        Lớp định nghĩa các thuộc tính (properties) và phương thức (methods)
                        mà các đối tượng thuộc lớp đó sẽ có.

                    Interface : Là một tập hợp các khai báo phương thức(methods signatures) và 
                        thuộc tính (property signatures) mà không có phần thân (implementation).
                        các lớp triển khai(implement) interface phải cung cấp phần thân cho các
                        phương thức và thuộc tính này
                
            2. Thành phần :
                    Lớp (class) : Có thể chứa các thuộc tính, phương thức, constructors, destructors,
                        và cả các phương thức trừu tượng (abstract methods).
                        - Có thể chứa các phương thức tĩnh (static methods) và thuộc tính tĩnh (static properties)
                        - Có thể chứa các trường (fields), constructors và cả các khối lệnh khởi tạo (initializers).

                    Interface : 
                        - Chỉ chứa các khai báo phương thức và thuộc tính, không có phần thân.
                        - Không chứa các trường, constructors,destructors hoặc các khối lệnh khởi tạo
                        - Không chứa các phương thức tĩnh hoặc thuộc tính tĩnh.

            3.Kế thừa :
                    Lớp(class) : 
                        - Có thể kế thừa từ 1 lớp khác
                        - Có thể triển khai một hoặc nhiều interfaces
                        - có thể chứa các phương thức đã triển khai và các phương thức trừu tượng nếu là lớp trừu tượng.

                    Interface :
                        - Không thể kế thừa từ lớp, chỉ có thể kế thừa từ 1 hay nhiều interface khác
                        - Một lớp có thể triển khai nhiều interfaces cùng 1 lúc
           
            4. Tính khởi tạo :
                    Lớp (class) :
                        - Có thể khởi tạo đối tượng trực tiếp thông qua constructors
                        - Có thể có constructors mặc định hoặc constructors có tham số

                    Interface :

                        - Không thể khởi tạo đối tượng trực tiếp từ interface
                        - Interface chỉ có thể được triển khai bởi các lớp cụ thể
             */


            //2) Sự khác nhau giữa giao diện và lớp trừu tượng? 

            /*
                - Lớp trừu tượng có thể kế thừa một lớp và nhiều interface, còn interface chỉ kế thừa được nhiều interface
                - Lớp trừu tượng có thể có phương thức thông thường( có thân) nhưng interface chỉ gồm các phương thức trufu tượng
                - Phương thức của lớp trừu tượng được cài đặt bằng từ khóa override, phương thức của interface được đặt mà không dùng từ khóa override
                - Sử dụng lớp trừu tượng khi bạn muốn trong lớp vừa có phương thức trừu tượng và có phương thức bình thường. Sử dụng 
                  interface khi chỉ khai báo các phương thức trừu tượng.
                - Lớp trừu tượng có thể khai báo phương thức khởi tạo, hàm hủy bên trong lớp , còn interface thì không
             */

            //3) Các lớp thực thi giao diện sẽ phải làm gì? 

            /*
                Các lớp thực thi(implement) một interface, lớp đó phải tuân thủ theo các quy tắc và cung cấp phần thân cho tất cả các 
                phương thức và thuộc tính được khai báo trong interface.
                Mọi phương thức và thuộc tính được khai báo trong interface phải được triển khai đầy đủ trong lớp. 
                Điều này có nghĩa là lớp phải cung cấp phần thân cho các phương thức và cung cấp các getter và setter cho các thuộc tính
             */


            //4) Có bao nhiêu cách gọi một phương thức được khai báo trong interface? 

            /*
             Có 5 cách :
                1. Trực tiếp qua đối tượng của lớp triển khai.
                2. Qua một biến kiểu interface.
                3. Qua phương thức tường minh (Explicit Interface Implementation).
                4. Từ một phương thức tĩnh hoặc phương thức khác trong lớp triển khai.
                5. Từ một phương thức trong một lớp khác.
             */

            //5) Các thành viên của giao diện có thể có những thuộc tính truy cập nào ?

            /*
                 Các thành viên của interface trong C# đều ngầm định là public, 
                và không thể sử dụng các thuộc tính truy cập khác như private, protected, hoặc internal cho các thành viên này. 
                Điều này giúp đảm bảo rằng bất kỳ lớp nào thực thi interface đều phải tuân theo các hợp đồng đã được định nghĩa trong interface, 
                giúp tăng tính nhất quán và khả năng tái sử dụng của mã nguồn.
             */

            //6) Chúng ta có thể tạo thể hiện của giao diện một cách trực tiếp được không?

            /*
                Không, chúng ta không thể tạo thể hiện của một giao diện (interface) một cách trực tiếp trong C#.
                Giao diện chỉ định nghĩa một tập hợp các phương thức, thuộc tính, 
                sự kiện và chỉ mục mà lớp hoặc cấu trúc phải thực hiện,
                nhưng nó không cung cấp phần thân cho các phương thức này. 
                Do đó, giao diện không thể được khởi tạo thành đối tượng cụ thể.
             */

            //7) Giao diện là kiểu dữ liệu tham chiếu hay kiểu giá trị? 

            // Giao diện (interface) trong C# là một kiểu dữ liệu tham chiếu (reference type).


            //8) Khi thực thi giao diện với cấu trúc thì truy cập các thành viên của giao diện thông qua dối tượng
            //hay thông qua tham chiếu giao diện là tốt nhất ?

            //Khi thực thi một giao diện bằng cấu trúc (struct) trong C#, truy cập các thành viên của giao diện thông qua tham chiếu giao diện là tốt nhất.
            //Điều này giúp tránh các vấn đề liên quan đến việc sao chép giá trị không mong muốn và tận dụng được tính chất tham chiếu của giao diện.

            //9) Số giao diện có thể dược kế thừa cho một lớp ?
            //Một lớp có thể được kế thừa nhiều interface

            //10) Việc thực thi giao diện tường minh là thực thi như thế nào? Trong trường hợp nào thì cần thực
            //hiện tường minh ?

            //Thực thi giao diện tường minh trong C# là cách định nghĩa các thành viên giao diện sao cho chúng chỉ có thể được gọi thông qua tham chiếu kiểu giao diện.
            //Điều này hữu ích khi bạn muốn tránh xung đột tên, kiểm soát truy cập đến các thành viên giao diện, hoặc hỗ trợ các tình huống đa hình phức tạp


            //11) Hãy viết một giao diện khai báo một thuộc tính ID chứa chuỗi giá trị.Viết một lớp Employee
            //thực thi giao diện ñó.

            {

                Employee employee = new Employee("E001", "John Doe", 30);

                employee.DisplayInfo(); 

                IEntity entity = employee;
                Console.WriteLine($"Employee ID từ interface: {entity.ID}"); 
            }

        }
    }
}
