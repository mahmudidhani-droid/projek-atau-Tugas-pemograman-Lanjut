using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;

namespace MaxSubarrayVisualizer
{
    public partial class Form1 : Form
    {
        // ============================================
        // DATA HARDCODE (WAJIB DIGUNAKAN PERSIS)
        // ============================================
        string[] hari = {
            "Hari 1", "Hari 2", "Hari 3", "Hari 4", "Hari 5",
            "Hari 6", "Hari 7", "Hari 8", "Hari 9", "Hari 10",
            "Hari 11", "Hari 12", "Hari 13", "Hari 14", "Hari 15"
        };

        int[] dataSahamAwal = {
            12, -15, 20, -5, 30,
            -10, 45, -60, 25, 10,
            -15, 35, -20, 15, -5
        };

        // Data kerja
        string[] namaHari;
        int[] fluktuasiSaham;

        // ============================================
        // STRUKTUR VISUALISASI STEP
        // ============================================
        public class StepInfo
        {
            public int[] KuningIndices { get; set; }
            public int[] MerahIndices { get; set; }
            public int[] HijauIndices { get; set; }
            public string Keterangan { get; set; }
            public int CurrentMaxSum { get; set; }
            public int[] CurrentMaxRange { get; set; }
        }

        List<StepInfo> stepsBruteForce = new List<StepInfo>();
        List<StepInfo> stepsDivideConquer = new List<StepInfo>();
        int currentStepBF = -1;
        int currentStepDC = -1;

        // ============================================
        // CONSTRUCTOR
        // ============================================
        public Form1()
        {
            InitializeComponent();
            InitializeData();
            RunBruteForceAlgorithm();
            RunDivideConquerAlgorithm();
            DisplayInitialData();
        }

        private void InitializeData()
        {
            namaHari = (string[])hari.Clone();
            fluktuasiSaham = (int[])dataSahamAwal.Clone();
        }

        // ============================================
        // DISPLAY INITIAL DATA
        // ============================================
        private void DisplayInitialData()
        {
            SetupGrid(dgvData);
            SetupGrid(dgvBruteForce);
            SetupGrid(dgvDivideConquer);
        }

        private void SetupGrid(DataGridView dgv)
        {
            dgv.Columns.Clear();
            dgv.Rows.Clear();

            dgv.Columns.Add("Type", "");
            for (int i = 0; i < namaHari.Length; i++)
            {
                dgv.Columns.Add($"Col{i}", namaHari[i]);
            }

            dgv.Rows.Add("Fluktuasi");
            for (int i = 0; i < fluktuasiSaham.Length; i++)
            {
                dgv.Rows[0].Cells[i + 1].Value = fluktuasiSaham[i];
                if (fluktuasiSaham[i] < 0)
                    dgv.Rows[0].Cells[i + 1].Style.ForeColor = Color.Red;
                else
                    dgv.Rows[0].Cells[i + 1].Style.ForeColor = Color.Green;
            }
            dgv.Rows[0].Cells[0].Value = "Nilai";
            dgv.Rows[0].Cells[0].Style.Font = new Font("Segoe UI", 9, FontStyle.Bold);
        }

        // ============================================
        // BRUTE FORCE ALGORITHM WITH VISUALIZATION
        // ============================================
        private void RunBruteForceAlgorithm()
        {
            stepsBruteForce.Clear();
            int n = fluktuasiSaham.Length;
            int maxSum = int.MinValue;
            int maxStart = 0, maxEnd = 0;

            stepsBruteForce.Add(new StepInfo
            {
                KuningIndices = new int[0],
                MerahIndices = new int[0],
                HijauIndices = new int[0],
                Keterangan = "Memulai algoritma Brute Force. Mencari subarray dengan profit maksimal.",
                CurrentMaxSum = maxSum,
                CurrentMaxRange = new int[0]
            });

            for (int i = 0; i < n; i++)
            {
                int currentSum = 0;
                for (int j = i; j < n; j++)
                {
                    currentSum += fluktuasiSaham[j];
                    int[] kuningRange = Enumerable.Range(i, j - i + 1).ToArray();

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        maxStart = i;
                        maxEnd = j;
                        int[] hijauRange = Enumerable.Range(maxStart, maxEnd - maxStart + 1).ToArray();

                        stepsBruteForce.Add(new StepInfo
                        {
                            KuningIndices = kuningRange,
                            MerahIndices = new int[0],
                            HijauIndices = hijauRange,
                            Keterangan = $"Menemukan subarray baru dengan profit lebih besar!\n" +
                                       $"Rentang: Hari {i + 1} - Hari {j + 1} | Sum = {currentSum}\n" +
                                       $"Profit maksimal sementara: {maxSum}",
                            CurrentMaxSum = maxSum,
                            CurrentMaxRange = hijauRange
                        });
                    }
                    else
                    {
                        stepsBruteForce.Add(new StepInfo
                        {
                            KuningIndices = kuningRange,
                            MerahIndices = new int[0],
                            HijauIndices = (maxSum > int.MinValue) ? Enumerable.Range(maxStart, maxEnd - maxStart + 1).ToArray() : new int[0],
                            Keterangan = $"Menguji subarray Hari {i + 1} - Hari {j + 1}\n" +
                                       $"Sum = {currentSum} (tidak mengalahkan {maxSum})",
                            CurrentMaxSum = maxSum,
                            CurrentMaxRange = (maxSum > int.MinValue) ? Enumerable.Range(maxStart, maxEnd - maxStart + 1).ToArray() : new int[0]
                        });
                    }
                }
            }

            int[] finalRange = Enumerable.Range(maxStart, maxEnd - maxStart + 1).ToArray();
            stepsBruteForce.Add(new StepInfo
            {
                KuningIndices = new int[0],
                MerahIndices = new int[0],
                HijauIndices = finalRange,
                Keterangan = $"ALGORITMA SELESAI!\n" +
                           $"Subarray maksimal: Hari {maxStart + 1} - Hari {maxEnd + 1}\n" +
                           $"Profit maksimal: {maxSum}",
                CurrentMaxSum = maxSum,
                CurrentMaxRange = finalRange
            });
        }

        // ============================================
        // DIVIDE & CONQUER ALGORITHM WITH VISUALIZATION
        // ============================================
        private void RunDivideConquerAlgorithm()
        {
            stepsDivideConquer.Clear();

            stepsDivideConquer.Add(new StepInfo
            {
                KuningIndices = new int[0],
                MerahIndices = new int[0],
                HijauIndices = new int[0],
                Keterangan = "Memulai algoritma Divide & Conquer.\nMembagi array menjadi sub-masalah yang lebih kecil.",
                CurrentMaxSum = int.MinValue,
                CurrentMaxRange = new int[0]
            });

            var result = FindMaximumSubarray(fluktuasiSaham, 0, fluktuasiSaham.Length - 1);

            int[] finalRange = Enumerable.Range(result.Item1, result.Item2 - result.Item1 + 1).ToArray();
            stepsDivideConquer.Add(new StepInfo
            {
                KuningIndices = new int[0],
                MerahIndices = new int[0],
                HijauIndices = finalRange,
                Keterangan = $"ALGORITMA SELESAI!\n" +
                           $"Subarray maksimal: Hari {result.Item1 + 1} - Hari {result.Item2 + 1}\n" +
                           $"Profit maksimal: {result.Item3}",
                CurrentMaxSum = result.Item3,
                CurrentMaxRange = finalRange
            });
        }

        private Tuple<int, int, int> FindMaximumSubarray(int[] A, int low, int high)
        {
            if (low == high)
            {
                stepsDivideConquer.Add(new StepInfo
                {
                    KuningIndices = new int[] { low },
                    MerahIndices = new int[0],
                    HijauIndices = new int[] { low },
                    Keterangan = $"BASE CASE tercapai di indeks {low} (Hari {low + 1})\n" +
                               $"Nilai: {A[low]}. Ini adalah subarray maksimal untuk rentang tunggal.",
                    CurrentMaxSum = A[low],
                    CurrentMaxRange = new int[] { low }
                });
                return Tuple.Create(low, high, A[low]);
            }

            int mid = (low + high) / 2;
            int[] kuningRange = Enumerable.Range(low, high - low + 1).ToArray();
            int[] merahRange = new int[] { mid };

            stepsDivideConquer.Add(new StepInfo
            {
                KuningIndices = kuningRange,
                MerahIndices = merahRange,
                HijauIndices = new int[0],
                Keterangan = $"MEMBAGI array dari indeks {low}-{high} (Hari {low + 1}-Hari {high + 1})\n" +
                           $"Titik tengah (mid): indeks {mid} (Hari {mid + 1})\n" +
                           $"Dibagi menjadi: kiri [{low}-{mid}] dan kanan [{mid + 1}-{high}]",
                CurrentMaxSum = int.MinValue,
                CurrentMaxRange = new int[0]
            });

            var leftResult = FindMaximumSubarray(A, low, mid);
            var rightResult = FindMaximumSubarray(A, mid + 1, high);
            var crossResult = FindMaxCrossingSubarray(A, low, mid, high);

            int bestSum = leftResult.Item3;
            int bestLow = leftResult.Item1;
            int bestHigh = leftResult.Item2;
            string bestSource = "kiri";

            if (rightResult.Item3 > bestSum)
            {
                bestSum = rightResult.Item3;
                bestLow = rightResult.Item1;
                bestHigh = rightResult.Item2;
                bestSource = "kanan";
            }
            if (crossResult.Item3 > bestSum)
            {
                bestSum = crossResult.Item3;
                bestLow = crossResult.Item1;
                bestHigh = crossResult.Item2;
                bestSource = "crossing";
            }

            int[] finalHijau = Enumerable.Range(bestLow, bestHigh - bestLow + 1).ToArray();
            int[] combineKuning = Enumerable.Range(low, high - low + 1).ToArray();

            stepsDivideConquer.Add(new StepInfo
            {
                KuningIndices = combineKuning,
                MerahIndices = new int[] { mid },
                HijauIndices = finalHijau,
                Keterangan = $"MENGGABUNGKAN hasil dari [{low}-{high}]\n" +
                           $"Kiri: [{leftResult.Item1}-{leftResult.Item2}] sum={leftResult.Item3}\n" +
                           $"Kanan: [{rightResult.Item1}-{rightResult.Item2}] sum={rightResult.Item3}\n" +
                           $"Crossing: [{crossResult.Item1}-{crossResult.Item2}] sum={crossResult.Item3}\n" +
                           $"Pemenang: {bestSource} dengan profit {bestSum}",
                CurrentMaxSum = bestSum,
                CurrentMaxRange = finalHijau
            });

            return Tuple.Create(bestLow, bestHigh, bestSum);
        }

        private Tuple<int, int, int> FindMaxCrossingSubarray(int[] A, int low, int mid, int high)
        {
            int[] crossKuning = Enumerable.Range(low, high - low + 1).ToArray();
            int[] crossMerah = new int[] { mid };

            stepsDivideConquer.Add(new StepInfo
            {
                KuningIndices = crossKuning,
                MerahIndices = crossMerah,
                HijauIndices = new int[0],
                Keterangan = $"FIND MAX CROSSING SUBARRAY [{low}-{high}] dengan mid={mid}\n" +
                           $"Mencari subarray maksimal yang melewati titik tengah.",
                CurrentMaxSum = int.MinValue,
                CurrentMaxRange = new int[0]
            });

            int leftSum = int.MinValue;
            int sum = 0;
            int maxLeft = mid;

            for (int i = mid; i >= low; i--)
            {
                sum += A[i];
                if (sum > leftSum)
                {
                    leftSum = sum;
                    maxLeft = i;
                }
            }

            int rightSum = int.MinValue;
            sum = 0;
            int maxRight = mid + 1;

            for (int j = mid + 1; j <= high; j++)
            {
                sum += A[j];
                if (sum > rightSum)
                {
                    rightSum = sum;
                    maxRight = j;
                }
            }

            int totalSum = leftSum + rightSum;
            int[] hijauCross = Enumerable.Range(maxLeft, maxRight - maxLeft + 1).ToArray();

            stepsDivideConquer.Add(new StepInfo
            {
                KuningIndices = crossKuning,
                MerahIndices = crossMerah,
                HijauIndices = hijauCross,
                Keterangan = $"CROSSING ditemukan: [{maxLeft}-{maxRight}] (Hari {maxLeft + 1}-Hari {maxRight + 1})\n" +
                           $"Left sum ({mid}->{maxLeft}): {leftSum}\n" +
                           $"Right sum ({mid + 1}->{maxRight}): {rightSum}\n" +
                           $"Total crossing: {totalSum}",
                CurrentMaxSum = totalSum,
                CurrentMaxRange = hijauCross
            });

            return Tuple.Create(maxLeft, maxRight, totalSum);
        }

        // ============================================
        // VISUALIZATION METHODS
        // ============================================
        private void DisplayStepBF(int stepIndex)
        {
            if (stepIndex < 0 || stepIndex >= stepsBruteForce.Count) return;

            var step = stepsBruteForce[stepIndex];

            for (int i = 0; i < fluktuasiSaham.Length; i++)
            {
                dgvBruteForce.Rows[0].Cells[i + 1].Style.BackColor = Color.White;
            }

            foreach (int idx in step.KuningIndices)
            {
                dgvBruteForce.Rows[0].Cells[idx + 1].Style.BackColor = Color.Yellow;
            }

            foreach (int idx in step.HijauIndices)
            {
                dgvBruteForce.Rows[0].Cells[idx + 1].Style.BackColor = Color.LightGreen;
            }

            txtKeteranganBF.Text = step.Keterangan;
            lblMaxSumBF.Text = $"Profit Maksimal: {step.CurrentMaxSum}";
            lblStepInfoBF.Text = $"Step: {stepIndex + 1} / {stepsBruteForce.Count}";
        }

        private void DisplayStepDC(int stepIndex)
        {
            if (stepIndex < 0 || stepIndex >= stepsDivideConquer.Count) return;

            var step = stepsDivideConquer[stepIndex];

            for (int i = 0; i < fluktuasiSaham.Length; i++)
            {
                dgvDivideConquer.Rows[0].Cells[i + 1].Style.BackColor = Color.White;
            }

            foreach (int idx in step.KuningIndices)
            {
                dgvDivideConquer.Rows[0].Cells[idx + 1].Style.BackColor = Color.Yellow;
            }

            foreach (int idx in step.MerahIndices)
            {
                dgvDivideConquer.Rows[0].Cells[idx + 1].Style.BackColor = Color.LightCoral;
            }

            foreach (int idx in step.HijauIndices)
            {
                dgvDivideConquer.Rows[0].Cells[idx + 1].Style.BackColor = Color.LightGreen;
            }

            txtKeteranganDC.Text = step.Keterangan;
            lblMaxSumDC.Text = $"Profit Maksimal: {step.CurrentMaxSum}";
            lblStepInfoDC.Text = $"Step: {stepIndex + 1} / {stepsDivideConquer.Count}";
        }

        // ============================================
        // NAVIGATION METHODS
        // ============================================
        private void NextStepBF()
        {
            if (currentStepBF < stepsBruteForce.Count - 1)
            {
                currentStepBF++;
                DisplayStepBF(currentStepBF);
            }
            else
            {
                timerAutoBF.Stop();
                btnAutoBF.Text = "Auto Play";
            }
        }

        private void PrevStepBF()
        {
            if (currentStepBF > 0)
            {
                currentStepBF--;
                DisplayStepBF(currentStepBF);
            }
        }

        private void ResetBF()
        {
            timerAutoBF.Stop();
            btnAutoBF.Text = "Auto Play";
            currentStepBF = -1;
            for (int i = 0; i < fluktuasiSaham.Length; i++)
            {
                dgvBruteForce.Rows[0].Cells[i + 1].Style.BackColor = Color.White;
            }
            txtKeteranganBF.Text = "Klik 'Next' untuk memulai visualisasi Brute Force.";
            lblMaxSumBF.Text = "Profit Maksimal: -";
            lblStepInfoBF.Text = $"Step: 0 / {stepsBruteForce.Count}";
        }

        private void ToggleAutoBF()
        {
            if (timerAutoBF.Enabled)
            {
                timerAutoBF.Stop();
                btnAutoBF.Text = "Auto Play";
            }
            else
            {
                if (currentStepBF >= stepsBruteForce.Count - 1)
                    currentStepBF = -1;
                timerAutoBF.Start();
                btnAutoBF.Text = "Pause";
            }
        }

        private void NextStepDC()
        {
            if (currentStepDC < stepsDivideConquer.Count - 1)
            {
                currentStepDC++;
                DisplayStepDC(currentStepDC);
            }
            else
            {
                timerAutoDC.Stop();
                btnAutoDC.Text = "Auto Play";
            }
        }

        private void PrevStepDC()
        {
            if (currentStepDC > 0)
            {
                currentStepDC--;
                DisplayStepDC(currentStepDC);
            }
        }

        private void ResetDC()
        {
            timerAutoDC.Stop();
            btnAutoDC.Text = "Auto Play";
            currentStepDC = -1;
            for (int i = 0; i < fluktuasiSaham.Length; i++)
            {
                dgvDivideConquer.Rows[0].Cells[i + 1].Style.BackColor = Color.White;
            }
            txtKeteranganDC.Text = "Klik 'Next' untuk memulai visualisasi Divide & Conquer.";
            lblMaxSumDC.Text = "Profit Maksimal: -";
            lblStepInfoDC.Text = $"Step: 0 / {stepsDivideConquer.Count}";
        }

        private void ToggleAutoDC()
        {
            if (timerAutoDC.Enabled)
            {
                timerAutoDC.Stop();
                btnAutoDC.Text = "Auto Play";
            }
            else
            {
                if (currentStepDC >= stepsDivideConquer.Count - 1)
                    currentStepDC = -1;
                timerAutoDC.Start();
                btnAutoDC.Text = "Pause";
            }
        }

        // ============================================
        // BENCHMARKING
        // ============================================
        private void RunBenchmark()
        {
            txtBenchmark.Clear();
            txtBenchmark.AppendText("===================================================\n");
            txtBenchmark.AppendText("     BENCHMARKING MAXIMUM SUBARRAY PROBLEM\n");
            txtBenchmark.AppendText("     Dataset: 10,000 elemen acak\n");
            txtBenchmark.AppendText("===================================================\n\n");

            Random rnd = new Random();
            int[] benchmarkData = new int[10000];
            for (int i = 0; i < benchmarkData.Length; i++)
            {
                benchmarkData[i] = rnd.Next(-1000, 1001);
            }

            txtBenchmark.AppendText($"Array acak 10.000 elemen berhasil digenerate.\n");
            txtBenchmark.AppendText($"Range nilai: -1000 sampai +1000\n\n");

            txtBenchmark.AppendText("Menjalankan Brute Force...\n");
            Application.DoEvents();

            Stopwatch swBF = new Stopwatch();
            swBF.Start();
            int bfResult = BruteForceMaxSubarray(benchmarkData);
            swBF.Stop();

            long msBF = swBF.ElapsedMilliseconds;
            txtBenchmark.AppendText($"   Brute Force selesai!\n");
            txtBenchmark.AppendText($"   Profit Maksimal: {bfResult}\n");
            txtBenchmark.AppendText($"   Waktu Eksekusi: {msBF} ms\n\n");

            txtBenchmark.AppendText("Menjalankan Divide & Conquer...\n");
            Application.DoEvents();

            Stopwatch swDC = new Stopwatch();
            swDC.Start();
            var dcResult = DnCMaxSubarray(benchmarkData, 0, benchmarkData.Length - 1);
            swDC.Stop();

            long msDC = swDC.ElapsedMilliseconds;
            txtBenchmark.AppendText($"   Divide & Conquer selesai!\n");
            txtBenchmark.AppendText($"   Profit Maksimal: {dcResult.Item3}\n");
            txtBenchmark.AppendText($"   Waktu Eksekusi: {msDC} ms\n\n");

            txtBenchmark.AppendText("===================================================\n");
            txtBenchmark.AppendText("              HASIL PERBANDINGAN\n");
            txtBenchmark.AppendText("===================================================\n");
            txtBenchmark.AppendText($"   Brute Force (O(n^2)):     {msBF,8} ms\n");
            txtBenchmark.AppendText($"   Divide & Conquer (O(n log n)): {msDC,8} ms\n");

            if (msDC > 0)
            {
                double speedup = (double)msBF / msDC;
                txtBenchmark.AppendText($"\n   D&C lebih cepat {speedup:F2}x lipat!\n");
            }

            txtBenchmark.AppendText("\n");
            txtBenchmark.AppendText("   Teori: O(n^2) vs O(n log n)\n");
            txtBenchmark.AppendText($"   Untuk n=10.000:\n");
            txtBenchmark.AppendText($"   - n^2      = 100.000.000 operasi\n");
            txtBenchmark.AppendText($"   - n log n  ~ 132.877 operasi\n");
            txtBenchmark.AppendText($"   - Ratio teoritis: ~752x\n");
        }


        // ============================================
        // EVENT HANDLERS (called by Designer.cs)
        // ============================================
        private void btnPrevBF_Click(object sender, EventArgs e)
        {
            PrevStepBF();
        }

        private void btnNextBF_Click(object sender, EventArgs e)
        {
            NextStepBF();
        }

        private void btnAutoBF_Click(object sender, EventArgs e)
        {
            ToggleAutoBF();
        }

        private void btnResetBF_Click(object sender, EventArgs e)
        {
            ResetBF();
        }

        private void btnPrevDC_Click(object sender, EventArgs e)
        {
            PrevStepDC();
        }

        private void btnNextDC_Click(object sender, EventArgs e)
        {
            NextStepDC();
        }

        private void btnAutoDC_Click(object sender, EventArgs e)
        {
            ToggleAutoDC();
        }

        private void btnResetDC_Click(object sender, EventArgs e)
        {
            ResetDC();
        }

        private void btnBenchmark_Click(object sender, EventArgs e)
        {
            RunBenchmark();
        }

        private void timerAutoBF_Tick(object sender, EventArgs e)
        {
            NextStepBF();
        }

        private void timerAutoDC_Tick(object sender, EventArgs e)
        {
            NextStepDC();
        }

        private int BruteForceMaxSubarray(int[] arr)
        {
            int n = arr.Length;
            int maxSum = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                int sum = 0;
                for (int j = i; j < n; j++)
                {
                    sum += arr[j];
                    if (sum > maxSum)
                        maxSum = sum;
                }
            }
            return maxSum;
        }

        private Tuple<int, int, int> DnCMaxSubarray(int[] A, int low, int high)
        {
            if (low == high)
                return Tuple.Create(low, high, A[low]);

            int mid = (low + high) / 2;
            var left = DnCMaxSubarray(A, low, mid);
            var right = DnCMaxSubarray(A, mid + 1, high);
            var cross = DnCMaxCrossing(A, low, mid, high);

            if (left.Item3 >= right.Item3 && left.Item3 >= cross.Item3)
                return left;
            else if (right.Item3 >= left.Item3 && right.Item3 >= cross.Item3)
                return right;
            else
                return cross;
        }

        private Tuple<int, int, int> DnCMaxCrossing(int[] A, int low, int mid, int high)
        {
            int leftSum = int.MinValue;
            int sum = 0;
            int maxLeft = mid;
            for (int i = mid; i >= low; i--)
            {
                sum += A[i];
                if (sum > leftSum)
                {
                    leftSum = sum;
                    maxLeft = i;
                }
            }

            int rightSum = int.MinValue;
            sum = 0;
            int maxRight = mid + 1;
            for (int j = mid + 1; j <= high; j++)
            {
                sum += A[j];
                if (sum > rightSum)
                {
                    rightSum = sum;
                    maxRight = j;
                }
            }

            return Tuple.Create(maxLeft, maxRight, leftSum + rightSum);
        }

        private void txtBenchmark_TextChanged(object sender, EventArgs e)
        {

        }

        private void gbBenchmark_Enter(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}