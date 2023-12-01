# -*- coding: utf-8 -*-
"""
Created on Fri Dec  1 10:35:10 2023

@author: mfa
"""
import numpy as np
import matplotlib.pyplot as plt


def getValues(pfad):
    dateipfad = pfad
    f = open(dateipfad, "r")
    daten = f.read()
    daten = daten[:-1]
    daten = daten.split(",")
    daten = [float(x) for x in daten]
    return daten



dateipfadMessungen = r"C:\Users\mfa\source\repos\DTP-Aufgaben-M.-Faessler\MergeSort_Portfolio_MFaessler\bin\Debug\net7.0\Messungen.txt"
dateipfadXWerte = r"C:\Users\mfa\source\repos\DTP-Aufgaben-M.-Faessler\MergeSort_Portfolio_MFaessler\bin\Debug\net7.0\AnzahlWerte.txt"

pathQSort = r"C:\Users\mfa\source\repos\DTP-Aufgaben-M.-Faessler\Datenstrukturen_Quicksort\bin\Debug\net7.0\MessungenQSort.txt"
pathXQSort = r"C:\Users\mfa\source\repos\DTP-Aufgaben-M.-Faessler\Datenstrukturen_Quicksort\bin\Debug\net7.0\AnzahlWerteQSort.txt"



daten = getValues(dateipfadMessungen)
xWerte = getValues(dateipfadXWerte)
#print(daten)
datenQS = getValues(pathQSort)
xWerteQS = getValues(pathXQSort)


daten = daten[:-1]
xWerte = xWerte[:-1]


datenQS = datenQS[:-1]
xWerteQS = xWerteQS[:-1]
#☺x = [1000+1000*i for i in range(len(daten))]
#plt.plot(x, daten)

arr = np.array(daten)
x = np.array(xWerte)
#arr = np.delete(arr, np.where(arr >= 250))
#x = [100*(1+i) for i in range(len(arr))]
plt.style.use("ggplot")
plt.plot(x, arr, color='blue', label="MergeSort")


arrQS = np.array(datenQS)
xQS = np.array(xWerteQS)

plt.plot(xQS, arrQS, color='red', label="QuickSort")
plt.legend()
