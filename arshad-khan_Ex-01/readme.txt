1. My application consists of labels, buttons, textboxes, radio buttons, a picture box, 
and a tableLayout panel.
-> My labels are mainly used for design purposes and to describe a functionality.
-> my application has 8 buttons in the main form and 2 buttons in the secondary form.

The button "buttonCalcGPA" is used to calculate the GPA.
The button "buttonTargetForm" is used to open the second form.
The button "buttonGetCourse" is used to retrieve the corresponding credit amount for the 
course code that is entered.
The button "buttonCourseList" is used to retrieve a list of all the courses.
The button "buttonAllCnet" is used to retrieve a list of all cnet courses.
The button "buttonMathCourse" is used to retrieve a list of all math courses.
The button "button3CreditCour" is used to retrieve a list of all 3 credit courses.
the button "button4CredCour" is used to retrieve a list of all 4 credit courses.

For my second form:
the button "buttonCalcTarget" is used to calculate the target GPA.
the button "buttonExit" is used to exit the TargetGpa calculator.

-> my main form has 14 textboxes and 4 textboxes in my secondary form.
7 of the textboxes are used for entering your course ID to match it to its corresponding credits 
and GPA
The other 7 textboxes are used for the GPA calculation.

For my second form:
The 4 textboxes are used for the target GPA calculation.

-> I have 3 radio buttons in my main form.
they have no real functionality and are just used to select the semester for which you are 
calculating the GPA.

-> I have one picturebox that is used for design purposes (displays centennial college logo).
-> I have one tablelayout panel and it is used for design purposes. 
The tablelayout panel is used to create a table that depicts the conversion from letter grade
to grade point.

2. I have 7 comboboxes in my main form.
These comboboxes are used to display the amount of credits that the courses are worth.
Their values are also used in the GPA calculation.

3. I have 1 dictionary and 5 lists.
-> the dictionary is used with the button "buttonGetCourse" to retrieve the corresponding 
credit amount for the course code entered.
The course code is entered as a string and returns the course credit amount as a string as well.
-> my 5 lists are used to return a list of the following:
A list of all the courses ("buttonCourseList").
A list of all Cnet courses ("buttonAllCnet").
A list of all Math courses ("buttonMathCourse").
A list of all 3 credit courses ("button3CreditCour").
A list of all 4 credit courses ("button4CredCour").

4. The data to be read from a text file and displayed in the datagridview is as follows: 

COURSE	CREDITS	GRADES
Comp213	4	4.5
Comp100	4	4.5
Comp120	4	4.0
Math175	3	4.5

** all values and words are seperated by tabs.

5. The data that is sent to the main form from the second form is:
The target GPA result that is calculated.

6. I used 4 items
-> The first item was the timer which is used for the clock in the bottom right hand corner
of my application.
-> The second item was the progress bar which is used for the splash screen.
-> The third item is a panel which is used to hold the 4 buttons above my datagridview
-> The fourth item is a splitcontainer that I used to split the panel holding the 4 buttons above
the datagridview.

7. I used 5 LINQ queries: 
-> The first one is used in "buttonCourseList_Click" and is used to sort the courses alphabetically.
-> The second one is used in "buttonAllCnet_Click" and is used to display only Cnet courses.
-> The third one is used in "buttonMathCourse_Click" and is used to display only Math courses.
-> The fourth one is used in "button3CreditCour_Click" and is used to display all 3 credit courses.
-> The fifth one is used in "button4CredCour" and is used to display all 4 credit courses.

8. My generic method is called SendValue<T>()
This method is used to send the resulting value from the second form (TargetGpa) to the main form.