## School Diary System

### Project Overview

Your task is to implement a school diary system using C# with a console-based interface. In the future, this system will
be extended to include a different UI, but for now, focus on creating a robust school diary system with console 
interface. This task will help you understand the core principles of C# programming, data management, and 
console-based UI development.

### Functional Requirements

| ID   | Requirement Description                                                                   |
|------|-------------------------------------------------------------------------------------------|
| FR1  | The system shall allow adding new students with details such as name, age, and class.     |
| FR2  | The system shall allow adding new subjects with details such as subject name and teacher. |
| FR3  | The system shall allow assigning subjects to students.                                    |
| FR4  | The system shall allow recording attendance for each student in each subject.             |
| FR5  | The system shall allow recording grades for students in each subject.                     |
| FR6  | The system shall display a list of students with their details.                           |
| FR7  | The system shall display a list of subjects with their details.                           |
| FR8  | The system shall display attendance records for each student.                             |
| FR9  | The system shall display grades for each student.                                         |
| FR10 | The system shall allow updating student and subject details.                              |
| FR11 | The system shall allow deleting students and subjects.                                    |

### Non-Functional Requirements

| ID   | Requirement Description                                                          |
|------|----------------------------------------------------------------------------------|
| NFR1 | The system shall be implemented using C#.                                        |
| NFR2 | The system shall use a console-based user interface.                             |
| NFR3 | The system shall be designed to easily extend to other UIs in the future.        |
| NFR4 | The system shall handle a minimum of 100 students and 10 subjects.               |
| NFR5 | The system shall ensure data consistency and integrity.                          |
| NFR6 | The system shall provide clear and informative error messages.                   |
| NFR7 | The system shall follow best practices for code readability and maintainability. |

### Use Cases

| Use Case ID | Use Case Description                     | Event Flow Description                                                                                                                                                              |
|-------------|------------------------------------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| UC1         | Add a new student                        | 1. User selects "Add Student" option.<br>2. System prompts for student details.<br>3. User enters details.<br>4. System saves the student.                                          |
| UC2         | Add a new subject                        | 1. User selects "Add Subject" option.<br>2. System prompts for subject details.<br>3. User enters details.<br>4. System saves the subject.                                          |
| UC3         | Assign subject to student                | 1. User selects "Assign Subject" option.<br>2. System prompts for student and subject selection.<br>3. User assigns subject to student.<br>4. System saves the assignment.          |
| UC4         | Record attendance                        | 1. User selects "Record Attendance" option.<br>2. System prompts for student and subject selection.<br>3. User enters attendance details.<br>4. System saves the attendance record. |
| UC5         | Record grades                            | 1. User selects "Record Grades" option.<br>2. System prompts for student and subject selection.<br>3. User enters grades.<br>4. System saves the grades.                            |
| UC6         | Display list of students                 | 1. User selects "Display Students" option.<br>2. System retrieves and displays the list of students.                                                                                |
| UC7         | Display list of subjects                 | 1. User selects "Display Subjects" option.<br>2. System retrieves and displays the list of subjects.                                                                                |
| UC8         | Display attendance records for a student | 1. User selects "Display Attendance" option.<br>2. System prompts for student selection.<br>3. System retrieves and displays the attendance records.                                |
| UC9         | Display grades for a student             | 1. User selects "Display Grades" option.<br>2. System prompts for student selection.<br>3. System retrieves and displays the grades.                                                |
| UC10        | Update student or subject details        | 1. User selects "Update Details" option.<br>2. System prompts for student or subject selection.<br>3. User updates the details.<br>4. System saves the updates.                     |
| UC11        | Delete student or subject                | 1. User selects "Delete" option.<br>2. System prompts for student or subject selection.<br>3. User confirms deletion.<br>4. System deletes the student or subject.                  |

### Notes

- Ensure you follow best practices for C# programming and console application development.
- The system should be designed to allow easy addition of a different UI in the future, so consider this in your
  architecture.
- Some details on the requirements may need further clarification. Please feel free to ask questions to get a clearer
  understanding of the task.

Good luck, and feel free to reach out if you need any assistance during the implementation!
