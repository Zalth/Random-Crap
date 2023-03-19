import csv
import sys
from os.path import join
import PySimpleGUI as sg
import time

sg.theme('DarkAmber')
layout = [[sg.T("")], [sg.Text('Enter the CSV', justification='center'), sg.Input(),
                       sg.FileBrowse(key="-IN-")], [sg.Button('Submit')]]

window = sg.Window('CSV Converter', layout, resizable=True, finalize=True, element_justification='c', size=(500, 150))

while True:
    event, values = window.read()
    if event == sg.WIN_CLOSED or event == "Exit":
        window.close()
        break
    elif event == "Submit":
        print(values[0])
        CSVFile = values[0]
        window.close()


PenList = []
PenSales = []
PencilList = []
PencilSales = []
PaperList = []
PaperSales = []
totalPens = 0

with open(CSVFile) as csvfile:
    Contents = csv.reader(csvfile, delimiter=' ', quotechar='|')
    line_count = 0
    for rows in Contents:
        my_string = rows[0]
        my_list = my_string.split(",")
        print(f'On {my_list[0]}, there were {my_list[2]} {my_list[1]}(s) were ordered at a price of {my_list[3]} '
              f'dollars.')
        if my_list[1] == "Pens" or "Pen":
            PenList.append(int(my_list[2]))
            PenSales.append(int(my_list[2]) * int(my_list[3]))
        if my_list[1] == "Pencil":
            PencilList.append(int(my_list[2]))
            PencilSales.append(int(my_list[2]) * int(my_list[3]))
        if my_list[1] == "Paper":
            PaperList.append(int(my_list[2]))
            PaperSales.append(int(my_list[2]) * int(my_list[3]))
        line_count += 1

        grandTotal = (sum(PenSales) + sum(PencilSales) + sum(PaperSales))

print('Creating a new file')

timestring = time.strftime("%Y " " %m " " %d")

with open("output " + timestring + ".txt", "a") as f:
    print(f'Processed {line_count} lines.', file=f)
    print(f'You sold:', sum(PenList), "pens! You made: $", sum(PenSales), file=f)
    print(f'You sold:', sum(PencilList), "pencils! You made: $", sum(PencilSales), file=f)
    print(f'You sold:', sum(PaperList), "packs of paper! You made: $", sum(PaperSales), file=f)
    print(f'You sold: $', grandTotal, "worth of goods this month! Good Job!", file=f)
