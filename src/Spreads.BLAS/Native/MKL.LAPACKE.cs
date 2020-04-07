﻿// This Source Code Form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at http://mozilla.org/MPL/2.0/.

using System.Runtime.InteropServices;
using System.Security;
// ReSharper disable InconsistentNaming

namespace Spreads.Native
{
    public static unsafe partial class MKL
    {
        public static class LAPACKE
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dlamch")]
            internal static extern double Dlamch(sbyte cmach);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dlamch_work")]
            internal static extern double DlamchWork(sbyte cmach);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dlange")]
            internal static extern double Dlange(BLAS.LAYOUT matrixLayout, sbyte norm, int m, int n, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dlange_work")]
            internal static extern double DlangeWork(BLAS.LAYOUT matrixLayout, sbyte norm, int m, int n, double* a, int lda, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dlansy")]
            internal static extern double Dlansy(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, int n, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dlansy_work")]
            internal static extern double DlansyWork(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, int n, double* a, int lda, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dlantr")]
            internal static extern double Dlantr(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int m, int n, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dlantr_work")]
            internal static extern double DlantrWork(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int m, int n, double* a, int lda, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dlapy2")]
            internal static extern double Dlapy2(double x, double y);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dlapy2_work")]
            internal static extern double Dlapy2Work(double x, double y);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dlapy3")]
            internal static extern double Dlapy3(double x, double y, double z);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dlapy3_work")]
            internal static extern double Dlapy3Work(double x, double y, double z);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zlange")]
            internal static extern double Zlange(BLAS.LAYOUT matrixLayout, sbyte norm, int m, int n, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zlange_work")]
            internal static extern double ZlangeWork(BLAS.LAYOUT matrixLayout, sbyte norm, int m, int n, System.IntPtr a, int lda, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zlanhe")]
            internal static extern double Zlanhe(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, int n, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zlanhe_work")]
            internal static extern double ZlanheWork(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, int n, System.IntPtr a, int lda, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zlarcm")]
            internal static extern int Zlarcm(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, System.IntPtr b, int ldb, System.IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zlarcm_work")]
            internal static extern int ZlarcmWork(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, System.IntPtr b, int ldb, System.IntPtr c, int ldc, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zlacrm")]
            internal static extern int Zlacrm(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, double* b, int ldb, System.IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zlacrm_work")]
            internal static extern int ZlacrmWork(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, double* b, int ldb, System.IntPtr c, int ldc, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zlansy")]
            internal static extern double Zlansy(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, int n, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zlansy_work")]
            internal static extern double ZlansyWork(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, int n, System.IntPtr a, int lda, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zlantr")]
            internal static extern double Zlantr(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int m, int n, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zlantr_work")]
            internal static extern double ZlantrWork(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int m, int n, System.IntPtr a, int lda, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_clange")]
            internal static extern float Clange(BLAS.LAYOUT matrixLayout, sbyte norm, int m, int n, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_clange_work")]
            internal static extern float ClangeWork(BLAS.LAYOUT matrixLayout, sbyte norm, int m, int n, System.IntPtr a, int lda, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_clanhe")]
            internal static extern float Clanhe(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, int n, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_clanhe_work")]
            internal static extern float ClanheWork(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, int n, System.IntPtr a, int lda, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_clarcm")]
            internal static extern int Clarcm(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda, System.IntPtr b, int ldb, System.IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_clarcm_work")]
            internal static extern int ClarcmWork(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda, System.IntPtr b, int ldb, System.IntPtr c, int ldc, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_clacrm")]
            internal static extern int Clacrm(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, float* b, int ldb, System.IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_clacrm_work")]
            internal static extern int ClacrmWork(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, float* b, int ldb, System.IntPtr c, int ldc, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_clansy")]
            internal static extern float Clansy(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, int n, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_clansy_work")]
            internal static extern float ClansyWork(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, int n, System.IntPtr a, int lda, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_clantr")]
            internal static extern float Clantr(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int m, int n, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_clantr_work")]
            internal static extern float ClantrWork(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int m, int n, System.IntPtr a, int lda, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_slamch")]
            internal static extern float Slamch(sbyte cmach);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_slamch_work")]
            internal static extern float SlamchWork(sbyte cmach);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_slange")]
            internal static extern float Slange(BLAS.LAYOUT matrixLayout, sbyte norm, int m, int n, float* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_slange_work")]
            internal static extern float SlangeWork(BLAS.LAYOUT matrixLayout, sbyte norm, int m, int n, float* a, int lda, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_slansy")]
            internal static extern float Slansy(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, int n, float* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_slansy_work")]
            internal static extern float SlansyWork(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, int n, float* a, int lda, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_slantr")]
            internal static extern float Slantr(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int m, int n, float* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_slantr_work")]
            internal static extern float SlantrWork(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int m, int n, float* a, int lda, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_slapy2")]
            internal static extern float Slapy2(float x, float y);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_slapy2_work")]
            internal static extern float Slapy2Work(float x, float y);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_slapy3")]
            internal static extern float Slapy3(float x, float y, float z);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_slapy3_work")]
            internal static extern float Slapy3Work(float x, float y, float z);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cbbcsd")]
            internal static extern int Cbbcsd(BLAS.LAYOUT matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, sbyte jobv2t, BLAS.TRANS trans, int m, int p, int q, float* theta, float* phi, System.IntPtr u1, int ldu1, System.IntPtr u2, int ldu2, System.IntPtr v1t, int ldv1t, System.IntPtr v2t, int ldv2t, float* b11d, float* b11e, float* b12d, float* b12e, float* b21d, float* b21e, float* b22d, float* b22e);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cbbcsd_work")]
            internal static extern int CbbcsdWork(BLAS.LAYOUT matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, sbyte jobv2t, BLAS.TRANS trans, int m, int p, int q, float* theta, float* phi, System.IntPtr u1, int ldu1, System.IntPtr u2, int ldu2, System.IntPtr v1t, int ldv1t, System.IntPtr v2t, int ldv2t, float* b11d, float* b11e, float* b12d, float* b12e, float* b21d, float* b21e, float* b22d, float* b22e, float* rwork, int lrwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cbdsqr")]
            internal static extern int Cbdsqr(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int ncvt, int nru, int ncc, float* d, float* e, System.IntPtr vt, int ldvt, System.IntPtr u, int ldu, System.IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cbdsqr_work")]
            internal static extern int CbdsqrWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int ncvt, int nru, int ncc, float* d, float* e, System.IntPtr vt, int ldvt, System.IntPtr u, int ldu, System.IntPtr c, int ldc, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgbbrd")]
            internal static extern int Cgbbrd(BLAS.LAYOUT matrixLayout, sbyte vect, int m, int n, int ncc, int kl, int ku, System.IntPtr ab, int ldab, float* d, float* e, System.IntPtr q, int ldq, System.IntPtr pt, int ldpt, System.IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgbbrd_work")]
            internal static extern int CgbbrdWork(BLAS.LAYOUT matrixLayout, sbyte vect, int m, int n, int ncc, int kl, int ku, System.IntPtr ab, int ldab, float* d, float* e, System.IntPtr q, int ldq, System.IntPtr pt, int ldpt, System.IntPtr c, int ldc, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgbcon")]
            internal static extern int Cgbcon(BLAS.LAYOUT matrixLayout, sbyte norm, int n, int kl, int ku, System.IntPtr ab, int ldab, int* ipiv, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgbcon_work")]
            internal static extern int CgbconWork(BLAS.LAYOUT matrixLayout, sbyte norm, int n, int kl, int ku, System.IntPtr ab, int ldab, int* ipiv, float anorm, float* rcond, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgbequ")]
            internal static extern int Cgbequ(BLAS.LAYOUT matrixLayout, int m, int n, int kl, int ku, System.IntPtr ab, int ldab, float* r, float* c, float* rowcnd, float* colcnd, float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgbequ_work")]
            internal static extern int CgbequWork(BLAS.LAYOUT matrixLayout, int m, int n, int kl, int ku, System.IntPtr ab, int ldab, float* r, float* c, float* rowcnd, float* colcnd, float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgbequb")]
            internal static extern int Cgbequb(BLAS.LAYOUT matrixLayout, int m, int n, int kl, int ku, System.IntPtr ab, int ldab, float* r, float* c, float* rowcnd, float* colcnd, float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgbequb_work")]
            internal static extern int CgbequbWork(BLAS.LAYOUT matrixLayout, int m, int n, int kl, int ku, System.IntPtr ab, int ldab, float* r, float* c, float* rowcnd, float* colcnd, float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgbrfs")]
            internal static extern int Cgbrfs(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, System.IntPtr ab, int ldab, System.IntPtr afb, int ldafb, int* ipiv, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgbrfs_work")]
            internal static extern int CgbrfsWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, System.IntPtr ab, int ldab, System.IntPtr afb, int ldafb, int* ipiv, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* ferr, float* berr, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgbrfsx")]
            internal static extern int Cgbrfsx(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, sbyte equed, int n, int kl, int ku, int nrhs, System.IntPtr ab, int ldab, System.IntPtr afb, int ldafb, int* ipiv, float* r, float* c, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* rcond, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgbrfsx_work")]
            internal static extern int CgbrfsxWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, sbyte equed, int n, int kl, int ku, int nrhs, System.IntPtr ab, int ldab, System.IntPtr afb, int ldafb, int* ipiv, float* r, float* c, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* rcond, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgbsv")]
            internal static extern int Cgbsv(BLAS.LAYOUT matrixLayout, int n, int kl, int ku, int nrhs, System.IntPtr ab, int ldab, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgbsv_work")]
            internal static extern int CgbsvWork(BLAS.LAYOUT matrixLayout, int n, int kl, int ku, int nrhs, System.IntPtr ab, int ldab, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgbsvx")]
            internal static extern int Cgbsvx(BLAS.LAYOUT matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, System.IntPtr ab, int ldab, System.IntPtr afb, int ldafb, int* ipiv, sbyte* equed, float* r, float* c, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* rcond, float* ferr, float* berr, float* rpivot);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgbsvx_work")]
            internal static extern int CgbsvxWork(BLAS.LAYOUT matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, System.IntPtr ab, int ldab, System.IntPtr afb, int ldafb, int* ipiv, sbyte* equed, float* r, float* c, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* rcond, float* ferr, float* berr, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgbsvxx")]
            internal static extern int Cgbsvxx(BLAS.LAYOUT matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, System.IntPtr ab, int ldab, System.IntPtr afb, int ldafb, int* ipiv, sbyte* equed, float* r, float* c, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* rcond, float* rpvgrw, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgbsvxx_work")]
            internal static extern int CgbsvxxWork(BLAS.LAYOUT matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, System.IntPtr ab, int ldab, System.IntPtr afb, int ldafb, int* ipiv, sbyte* equed, float* r, float* c, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* rcond, float* rpvgrw, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgbtrf")]
            internal static extern int Cgbtrf(BLAS.LAYOUT matrixLayout, int m, int n, int kl, int ku, System.IntPtr ab, int ldab, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgbtrf_work")]
            internal static extern int CgbtrfWork(BLAS.LAYOUT matrixLayout, int m, int n, int kl, int ku, System.IntPtr ab, int ldab, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgbtrs")]
            internal static extern int Cgbtrs(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, System.IntPtr ab, int ldab, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgbtrs_work")]
            internal static extern int CgbtrsWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, System.IntPtr ab, int ldab, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgebak")]
            internal static extern int Cgebak(BLAS.LAYOUT matrixLayout, sbyte job, sbyte side, int n, int ilo, int ihi, float* scale, int m, System.IntPtr v, int ldv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgebak_work")]
            internal static extern int CgebakWork(BLAS.LAYOUT matrixLayout, sbyte job, sbyte side, int n, int ilo, int ihi, float* scale, int m, System.IntPtr v, int ldv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgebal")]
            internal static extern int Cgebal(BLAS.LAYOUT matrixLayout, sbyte job, int n, System.IntPtr a, int lda, int* ilo, int* ihi, float* scale);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgebal_work")]
            internal static extern int CgebalWork(BLAS.LAYOUT matrixLayout, sbyte job, int n, System.IntPtr a, int lda, int* ilo, int* ihi, float* scale);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgebrd")]
            internal static extern int Cgebrd(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, float* d, float* e, System.IntPtr tauq, System.IntPtr taup);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgebrd_work")]
            internal static extern int CgebrdWork(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, float* d, float* e, System.IntPtr tauq, System.IntPtr taup, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgecon")]
            internal static extern int Cgecon(BLAS.LAYOUT matrixLayout, sbyte norm, int n, System.IntPtr a, int lda, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgecon_work")]
            internal static extern int CgeconWork(BLAS.LAYOUT matrixLayout, sbyte norm, int n, System.IntPtr a, int lda, float anorm, float* rcond, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgeequ")]
            internal static extern int Cgeequ(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, float* r, float* c, float* rowcnd, float* colcnd, float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgeequ_work")]
            internal static extern int CgeequWork(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, float* r, float* c, float* rowcnd, float* colcnd, float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgeequb")]
            internal static extern int Cgeequb(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, float* r, float* c, float* rowcnd, float* colcnd, float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgeequb_work")]
            internal static extern int CgeequbWork(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, float* r, float* c, float* rowcnd, float* colcnd, float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgees")]
            internal static extern int Cgees(BLAS.LAYOUT matrixLayout, sbyte jobvs, sbyte sort, System.IntPtr select, int n, System.IntPtr a, int lda, int* sdim, System.IntPtr w, System.IntPtr vs, int ldvs);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgees_work")]
            internal static extern int CgeesWork(BLAS.LAYOUT matrixLayout, sbyte jobvs, sbyte sort, System.IntPtr select, int n, System.IntPtr a, int lda, int* sdim, System.IntPtr w, System.IntPtr vs, int ldvs, System.IntPtr work, int lwork, float* rwork, int* bwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgeesx")]
            internal static extern int Cgeesx(BLAS.LAYOUT matrixLayout, sbyte jobvs, sbyte sort, System.IntPtr select, sbyte sense, int n, System.IntPtr a, int lda, int* sdim, System.IntPtr w, System.IntPtr vs, int ldvs, float* rconde, float* rcondv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgeesx_work")]
            internal static extern int CgeesxWork(BLAS.LAYOUT matrixLayout, sbyte jobvs, sbyte sort, System.IntPtr select, sbyte sense, int n, System.IntPtr a, int lda, int* sdim, System.IntPtr w, System.IntPtr vs, int ldvs, float* rconde, float* rcondv, System.IntPtr work, int lwork, float* rwork, int* bwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgeev")]
            internal static extern int Cgeev(BLAS.LAYOUT matrixLayout, sbyte jobvl, sbyte jobvr, int n, System.IntPtr a, int lda, System.IntPtr w, System.IntPtr vl, int ldvl, System.IntPtr vr, int ldvr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgeev_work")]
            internal static extern int CgeevWork(BLAS.LAYOUT matrixLayout, sbyte jobvl, sbyte jobvr, int n, System.IntPtr a, int lda, System.IntPtr w, System.IntPtr vl, int ldvl, System.IntPtr vr, int ldvr, System.IntPtr work, int lwork, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgeevx")]
            internal static extern int Cgeevx(BLAS.LAYOUT matrixLayout, sbyte balanc, sbyte jobvl, sbyte jobvr, sbyte sense, int n, System.IntPtr a, int lda, System.IntPtr w, System.IntPtr vl, int ldvl, System.IntPtr vr, int ldvr, int* ilo, int* ihi, float* scale, float* abnrm, float* rconde, float* rcondv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgeevx_work")]
            internal static extern int CgeevxWork(BLAS.LAYOUT matrixLayout, sbyte balanc, sbyte jobvl, sbyte jobvr, sbyte sense, int n, System.IntPtr a, int lda, System.IntPtr w, System.IntPtr vl, int ldvl, System.IntPtr vr, int ldvr, int* ilo, int* ihi, float* scale, float* abnrm, float* rconde, float* rcondv, System.IntPtr work, int lwork, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgehrd")]
            internal static extern int Cgehrd(BLAS.LAYOUT matrixLayout, int n, int ilo, int ihi, System.IntPtr a, int lda, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgehrd_work")]
            internal static extern int CgehrdWork(BLAS.LAYOUT matrixLayout, int n, int ilo, int ihi, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgejsv")]
            internal static extern int Cgejsv(BLAS.LAYOUT matrixLayout, sbyte joba, sbyte jobu, sbyte jobv, sbyte jobr, sbyte jobt, sbyte jobp, int m, int n, System.IntPtr a, int lda, float* sva, System.IntPtr u, int ldu, System.IntPtr v, int ldv, float* stat, int* istat);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgejsv_work")]
            internal static extern int CgejsvWork(BLAS.LAYOUT matrixLayout, sbyte joba, sbyte jobu, sbyte jobv, sbyte jobr, sbyte jobt, sbyte jobp, int m, int n, System.IntPtr a, int lda, float* sva, System.IntPtr u, int ldu, System.IntPtr v, int ldv, System.IntPtr cwork, int lwork, float* rwork, int lrwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgelq2")]
            internal static extern int Cgelq2(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgelq2_work")]
            internal static extern int Cgelq2Work(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgelqf")]
            internal static extern int Cgelqf(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgelqf_work")]
            internal static extern int CgelqfWork(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgels")]
            internal static extern int Cgels(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int m, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgels_work")]
            internal static extern int CgelsWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int m, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgelsd")]
            internal static extern int Cgelsd(BLAS.LAYOUT matrixLayout, int m, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr b, int ldb, float* s, float rcond, int* rank);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgelsd_work")]
            internal static extern int CgelsdWork(BLAS.LAYOUT matrixLayout, int m, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr b, int ldb, float* s, float rcond, int* rank, System.IntPtr work, int lwork, float* rwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgelss")]
            internal static extern int Cgelss(BLAS.LAYOUT matrixLayout, int m, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr b, int ldb, float* s, float rcond, int* rank);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgelss_work")]
            internal static extern int CgelssWork(BLAS.LAYOUT matrixLayout, int m, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr b, int ldb, float* s, float rcond, int* rank, System.IntPtr work, int lwork, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgelsy")]
            internal static extern int Cgelsy(BLAS.LAYOUT matrixLayout, int m, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr b, int ldb, int* jpvt, float rcond, int* rank);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgelsy_work")]
            internal static extern int CgelsyWork(BLAS.LAYOUT matrixLayout, int m, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr b, int ldb, int* jpvt, float rcond, int* rank, System.IntPtr work, int lwork, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgemqrt")]
            internal static extern int Cgemqrt(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, int nb, System.IntPtr v, int ldv, System.IntPtr t, int ldt, System.IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgemqrt_work")]
            internal static extern int CgemqrtWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, int nb, System.IntPtr v, int ldv, System.IntPtr t, int ldt, System.IntPtr c, int ldc, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgeqlf")]
            internal static extern int Cgeqlf(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgeqlf_work")]
            internal static extern int CgeqlfWork(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgeqp3")]
            internal static extern int Cgeqp3(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, int* jpvt, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgeqp3_work")]
            internal static extern int Cgeqp3Work(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, int* jpvt, System.IntPtr tau, System.IntPtr work, int lwork, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgeqpf")]
            internal static extern int Cgeqpf(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, int* jpvt, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgeqpf_work")]
            internal static extern int CgeqpfWork(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, int* jpvt, System.IntPtr tau, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgeqr2")]
            internal static extern int Cgeqr2(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgeqr2_work")]
            internal static extern int Cgeqr2Work(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgeqrf")]
            internal static extern int Cgeqrf(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgeqrf_work")]
            internal static extern int CgeqrfWork(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgeqrfp")]
            internal static extern int Cgeqrfp(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgeqrfp_work")]
            internal static extern int CgeqrfpWork(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgeqrt")]
            internal static extern int Cgeqrt(BLAS.LAYOUT matrixLayout, int m, int n, int nb, System.IntPtr a, int lda, System.IntPtr t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgeqrt2")]
            internal static extern int Cgeqrt2(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgeqrt2_work")]
            internal static extern int Cgeqrt2Work(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgeqrt3")]
            internal static extern int Cgeqrt3(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgeqrt3_work")]
            internal static extern int Cgeqrt3Work(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgeqrt_work")]
            internal static extern int CgeqrtWork(BLAS.LAYOUT matrixLayout, int m, int n, int nb, System.IntPtr a, int lda, System.IntPtr t, int ldt, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgerfs")]
            internal static extern int Cgerfs(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, int* ipiv, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgerfs_work")]
            internal static extern int CgerfsWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, int* ipiv, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* ferr, float* berr, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgerfsx")]
            internal static extern int Cgerfsx(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, sbyte equed, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, int* ipiv, float* r, float* c, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* rcond, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgerfsx_work")]
            internal static extern int CgerfsxWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, sbyte equed, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, int* ipiv, float* r, float* c, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* rcond, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgerqf")]
            internal static extern int Cgerqf(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgerqf_work")]
            internal static extern int CgerqfWork(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgesdd")]
            internal static extern int Cgesdd(BLAS.LAYOUT matrixLayout, sbyte jobz, int m, int n, System.IntPtr a, int lda, float* s, System.IntPtr u, int ldu, System.IntPtr vt, int ldvt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgesdd_work")]
            internal static extern int CgesddWork(BLAS.LAYOUT matrixLayout, sbyte jobz, int m, int n, System.IntPtr a, int lda, float* s, System.IntPtr u, int ldu, System.IntPtr vt, int ldvt, System.IntPtr work, int lwork, float* rwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgesv")]
            internal static extern int Cgesv(BLAS.LAYOUT matrixLayout, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgesv_work")]
            internal static extern int CgesvWork(BLAS.LAYOUT matrixLayout, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgesvd")]
            internal static extern int Cgesvd(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobvt, int m, int n, System.IntPtr a, int lda, float* s, System.IntPtr u, int ldu, System.IntPtr vt, int ldvt, float* superb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgesvd_work")]
            internal static extern int CgesvdWork(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobvt, int m, int n, System.IntPtr a, int lda, float* s, System.IntPtr u, int ldu, System.IntPtr vt, int ldvt, System.IntPtr work, int lwork, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgesvdx")]
            internal static extern int Cgesvdx(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobvt, sbyte range, int m, int n, System.IntPtr a, int lda, float vl, float vu, int il, int iu, int* ns, float* s, System.IntPtr u, int ldu, System.IntPtr vt, int ldvt, int* superb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgesvdx_work")]
            internal static extern int CgesvdxWork(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobvt, sbyte range, int m, int n, System.IntPtr a, int lda, float vl, float vu, int il, int iu, int* ns, float* s, System.IntPtr u, int ldu, System.IntPtr vt, int ldvt, System.IntPtr work, int lwork, float* rwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgesvj")]
            internal static extern int Cgesvj(BLAS.LAYOUT matrixLayout, sbyte joba, sbyte jobu, sbyte jobv, int m, int n, System.IntPtr a, int lda, float* sva, int mv, System.IntPtr v, int ldv, float* stat);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgesvj_work")]
            internal static extern int CgesvjWork(BLAS.LAYOUT matrixLayout, sbyte joba, sbyte jobu, sbyte jobv, int m, int n, System.IntPtr a, int lda, float* sva, int mv, System.IntPtr v, int ldv, System.IntPtr cwork, int lwork, float* rwork, int lrwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgesvx")]
            internal static extern int Cgesvx(BLAS.LAYOUT matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, int* ipiv, sbyte* equed, float* r, float* c, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* rcond, float* ferr, float* berr, float* rpivot);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgesvx_work")]
            internal static extern int CgesvxWork(BLAS.LAYOUT matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, int* ipiv, sbyte* equed, float* r, float* c, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* rcond, float* ferr, float* berr, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgesvxx")]
            internal static extern int Cgesvxx(BLAS.LAYOUT matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, int* ipiv, sbyte* equed, float* r, float* c, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* rcond, float* rpvgrw, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgesvxx_work")]
            internal static extern int CgesvxxWork(BLAS.LAYOUT matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, int* ipiv, sbyte* equed, float* r, float* c, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* rcond, float* rpvgrw, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgetf2")]
            internal static extern int Cgetf2(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgetf2_work")]
            internal static extern int Cgetf2Work(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgetrf")]
            internal static extern int Cgetrf(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgetrf2")]
            internal static extern int Cgetrf2(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgetrf2_work")]
            internal static extern int Cgetrf2Work(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgetrf_work")]
            internal static extern int CgetrfWork(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgetri")]
            internal static extern int Cgetri(BLAS.LAYOUT matrixLayout, int n, System.IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgetri_work")]
            internal static extern int CgetriWork(BLAS.LAYOUT matrixLayout, int n, System.IntPtr a, int lda, int* ipiv, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgetrs")]
            internal static extern int Cgetrs(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgetrs_work")]
            internal static extern int CgetrsWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cggbak")]
            internal static extern int Cggbak(BLAS.LAYOUT matrixLayout, sbyte job, sbyte side, int n, int ilo, int ihi, float* lscale, float* rscale, int m, System.IntPtr v, int ldv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cggbak_work")]
            internal static extern int CggbakWork(BLAS.LAYOUT matrixLayout, sbyte job, sbyte side, int n, int ilo, int ihi, float* lscale, float* rscale, int m, System.IntPtr v, int ldv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cggbal")]
            internal static extern int Cggbal(BLAS.LAYOUT matrixLayout, sbyte job, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, int* ilo, int* ihi, float* lscale, float* rscale);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cggbal_work")]
            internal static extern int CggbalWork(BLAS.LAYOUT matrixLayout, sbyte job, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, int* ilo, int* ihi, float* lscale, float* rscale, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgges")]
            internal static extern int Cgges(BLAS.LAYOUT matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, System.IntPtr selctg, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, int* sdim, System.IntPtr alpha, System.IntPtr beta, System.IntPtr vsl, int ldvsl, System.IntPtr vsr, int ldvsr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgges3")]
            internal static extern int Cgges3(BLAS.LAYOUT matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, System.IntPtr selctg, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, int* sdim, System.IntPtr alpha, System.IntPtr beta, System.IntPtr vsl, int ldvsl, System.IntPtr vsr, int ldvsr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgges3_work")]
            internal static extern int Cgges3Work(BLAS.LAYOUT matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, System.IntPtr selctg, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, int* sdim, System.IntPtr alpha, System.IntPtr beta, System.IntPtr vsl, int ldvsl, System.IntPtr vsr, int ldvsr, System.IntPtr work, int lwork, float* rwork, int* bwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgges_work")]
            internal static extern int CggesWork(BLAS.LAYOUT matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, System.IntPtr selctg, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, int* sdim, System.IntPtr alpha, System.IntPtr beta, System.IntPtr vsl, int ldvsl, System.IntPtr vsr, int ldvsr, System.IntPtr work, int lwork, float* rwork, int* bwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cggesx")]
            internal static extern int Cggesx(BLAS.LAYOUT matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, System.IntPtr selctg, sbyte sense, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, int* sdim, System.IntPtr alpha, System.IntPtr beta, System.IntPtr vsl, int ldvsl, System.IntPtr vsr, int ldvsr, float* rconde, float* rcondv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cggesx_work")]
            internal static extern int CggesxWork(BLAS.LAYOUT matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, System.IntPtr selctg, sbyte sense, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, int* sdim, System.IntPtr alpha, System.IntPtr beta, System.IntPtr vsl, int ldvsl, System.IntPtr vsr, int ldvsr, float* rconde, float* rcondv, System.IntPtr work, int lwork, float* rwork, int* iwork, int liwork, int* bwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cggev")]
            internal static extern int Cggev(BLAS.LAYOUT matrixLayout, sbyte jobvl, sbyte jobvr, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr alpha, System.IntPtr beta, System.IntPtr vl, int ldvl, System.IntPtr vr, int ldvr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cggev3")]
            internal static extern int Cggev3(BLAS.LAYOUT matrixLayout, sbyte jobvl, sbyte jobvr, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr alpha, System.IntPtr beta, System.IntPtr vl, int ldvl, System.IntPtr vr, int ldvr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cggev3_work")]
            internal static extern int Cggev3Work(BLAS.LAYOUT matrixLayout, sbyte jobvl, sbyte jobvr, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr alpha, System.IntPtr beta, System.IntPtr vl, int ldvl, System.IntPtr vr, int ldvr, System.IntPtr work, int lwork, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cggev_work")]
            internal static extern int CggevWork(BLAS.LAYOUT matrixLayout, sbyte jobvl, sbyte jobvr, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr alpha, System.IntPtr beta, System.IntPtr vl, int ldvl, System.IntPtr vr, int ldvr, System.IntPtr work, int lwork, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cggevx")]
            internal static extern int Cggevx(BLAS.LAYOUT matrixLayout, sbyte balanc, sbyte jobvl, sbyte jobvr, sbyte sense, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr alpha, System.IntPtr beta, System.IntPtr vl, int ldvl, System.IntPtr vr, int ldvr, int* ilo, int* ihi, float* lscale, float* rscale, float* abnrm, float* bbnrm, float* rconde, float* rcondv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cggevx_work")]
            internal static extern int CggevxWork(BLAS.LAYOUT matrixLayout, sbyte balanc, sbyte jobvl, sbyte jobvr, sbyte sense, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr alpha, System.IntPtr beta, System.IntPtr vl, int ldvl, System.IntPtr vr, int ldvr, int* ilo, int* ihi, float* lscale, float* rscale, float* abnrm, float* bbnrm, float* rconde, float* rcondv, System.IntPtr work, int lwork, float* rwork, int* iwork, int* bwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cggglm")]
            internal static extern int Cggglm(BLAS.LAYOUT matrixLayout, int n, int m, int p, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr d, System.IntPtr x, System.IntPtr y);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cggglm_work")]
            internal static extern int CggglmWork(BLAS.LAYOUT matrixLayout, int n, int m, int p, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr d, System.IntPtr x, System.IntPtr y, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgghd3")]
            internal static extern int Cgghd3(BLAS.LAYOUT matrixLayout, sbyte compq, sbyte compz, int n, int ilo, int ihi, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr q, int ldq, System.IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgghd3_work")]
            internal static extern int Cgghd3Work(BLAS.LAYOUT matrixLayout, sbyte compq, sbyte compz, int n, int ilo, int ihi, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr q, int ldq, System.IntPtr z, int ldz, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgghrd")]
            internal static extern int Cgghrd(BLAS.LAYOUT matrixLayout, sbyte compq, sbyte compz, int n, int ilo, int ihi, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr q, int ldq, System.IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgghrd_work")]
            internal static extern int CgghrdWork(BLAS.LAYOUT matrixLayout, sbyte compq, sbyte compz, int n, int ilo, int ihi, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr q, int ldq, System.IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgglse")]
            internal static extern int Cgglse(BLAS.LAYOUT matrixLayout, int m, int n, int p, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr c, System.IntPtr d, System.IntPtr x);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgglse_work")]
            internal static extern int CgglseWork(BLAS.LAYOUT matrixLayout, int m, int n, int p, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr c, System.IntPtr d, System.IntPtr x, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cggqrf")]
            internal static extern int Cggqrf(BLAS.LAYOUT matrixLayout, int n, int m, int p, System.IntPtr a, int lda, System.IntPtr taua, System.IntPtr b, int ldb, System.IntPtr taub);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cggqrf_work")]
            internal static extern int CggqrfWork(BLAS.LAYOUT matrixLayout, int n, int m, int p, System.IntPtr a, int lda, System.IntPtr taua, System.IntPtr b, int ldb, System.IntPtr taub, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cggrqf")]
            internal static extern int Cggrqf(BLAS.LAYOUT matrixLayout, int m, int p, int n, System.IntPtr a, int lda, System.IntPtr taua, System.IntPtr b, int ldb, System.IntPtr taub);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cggrqf_work")]
            internal static extern int CggrqfWork(BLAS.LAYOUT matrixLayout, int m, int p, int n, System.IntPtr a, int lda, System.IntPtr taua, System.IntPtr b, int ldb, System.IntPtr taub, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cggsvd")]
            internal static extern int Cggsvd(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int n, int p, int* k, int* l, System.IntPtr a, int lda, System.IntPtr b, int ldb, float* alpha, float* beta, System.IntPtr u, int ldu, System.IntPtr v, int ldv, System.IntPtr q, int ldq, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cggsvd3")]
            internal static extern int Cggsvd3(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int n, int p, int* k, int* l, System.IntPtr a, int lda, System.IntPtr b, int ldb, float* alpha, float* beta, System.IntPtr u, int ldu, System.IntPtr v, int ldv, System.IntPtr q, int ldq, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cggsvd3_work")]
            internal static extern int Cggsvd3Work(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int n, int p, int* k, int* l, System.IntPtr a, int lda, System.IntPtr b, int ldb, float* alpha, float* beta, System.IntPtr u, int ldu, System.IntPtr v, int ldv, System.IntPtr q, int ldq, System.IntPtr work, int lwork, float* rwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cggsvd_work")]
            internal static extern int CggsvdWork(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int n, int p, int* k, int* l, System.IntPtr a, int lda, System.IntPtr b, int ldb, float* alpha, float* beta, System.IntPtr u, int ldu, System.IntPtr v, int ldv, System.IntPtr q, int ldq, System.IntPtr work, float* rwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cggsvp")]
            internal static extern int Cggsvp(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, float tola, float tolb, int* k, int* l, System.IntPtr u, int ldu, System.IntPtr v, int ldv, System.IntPtr q, int ldq);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cggsvp3")]
            internal static extern int Cggsvp3(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, float tola, float tolb, int* k, int* l, System.IntPtr u, int ldu, System.IntPtr v, int ldv, System.IntPtr q, int ldq);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cggsvp3_work")]
            internal static extern int Cggsvp3Work(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, float tola, float tolb, int* k, int* l, System.IntPtr u, int ldu, System.IntPtr v, int ldv, System.IntPtr q, int ldq, int* iwork, float* rwork, System.IntPtr tau, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cggsvp_work")]
            internal static extern int CggsvpWork(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, float tola, float tolb, int* k, int* l, System.IntPtr u, int ldu, System.IntPtr v, int ldv, System.IntPtr q, int ldq, int* iwork, float* rwork, System.IntPtr tau, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgtcon")]
            internal static extern int Cgtcon(sbyte norm, int n, System.IntPtr dl, System.IntPtr d, System.IntPtr du, System.IntPtr du2, int* ipiv, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgtcon_work")]
            internal static extern int CgtconWork(sbyte norm, int n, System.IntPtr dl, System.IntPtr d, System.IntPtr du, System.IntPtr du2, int* ipiv, float anorm, float* rcond, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgtrfs")]
            internal static extern int Cgtrfs(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int nrhs, System.IntPtr dl, System.IntPtr d, System.IntPtr du, System.IntPtr dlf, System.IntPtr df, System.IntPtr duf, System.IntPtr du2, int* ipiv, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgtrfs_work")]
            internal static extern int CgtrfsWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int nrhs, System.IntPtr dl, System.IntPtr d, System.IntPtr du, System.IntPtr dlf, System.IntPtr df, System.IntPtr duf, System.IntPtr du2, int* ipiv, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* ferr, float* berr, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgtsv")]
            internal static extern int Cgtsv(BLAS.LAYOUT matrixLayout, int n, int nrhs, System.IntPtr dl, System.IntPtr d, System.IntPtr du, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgtsv_work")]
            internal static extern int CgtsvWork(BLAS.LAYOUT matrixLayout, int n, int nrhs, System.IntPtr dl, System.IntPtr d, System.IntPtr du, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgtsvx")]
            internal static extern int Cgtsvx(BLAS.LAYOUT matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int nrhs, System.IntPtr dl, System.IntPtr d, System.IntPtr du, System.IntPtr dlf, System.IntPtr df, System.IntPtr duf, System.IntPtr du2, int* ipiv, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* rcond, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgtsvx_work")]
            internal static extern int CgtsvxWork(BLAS.LAYOUT matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int nrhs, System.IntPtr dl, System.IntPtr d, System.IntPtr du, System.IntPtr dlf, System.IntPtr df, System.IntPtr duf, System.IntPtr du2, int* ipiv, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* rcond, float* ferr, float* berr, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgttrf")]
            internal static extern int Cgttrf(int n, System.IntPtr dl, System.IntPtr d, System.IntPtr du, System.IntPtr du2, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgttrf_work")]
            internal static extern int CgttrfWork(int n, System.IntPtr dl, System.IntPtr d, System.IntPtr du, System.IntPtr du2, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgttrs")]
            internal static extern int Cgttrs(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int nrhs, System.IntPtr dl, System.IntPtr d, System.IntPtr du, System.IntPtr du2, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgttrs_work")]
            internal static extern int CgttrsWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int nrhs, System.IntPtr dl, System.IntPtr d, System.IntPtr du, System.IntPtr du2, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chbev")]
            internal static extern int Chbev(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, System.IntPtr ab, int ldab, float* w, System.IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chbev_work")]
            internal static extern int ChbevWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, System.IntPtr ab, int ldab, float* w, System.IntPtr z, int ldz, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chbevd")]
            internal static extern int Chbevd(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, System.IntPtr ab, int ldab, float* w, System.IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chbevd_work")]
            internal static extern int ChbevdWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, System.IntPtr ab, int ldab, float* w, System.IntPtr z, int ldz, System.IntPtr work, int lwork, float* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chbevx")]
            internal static extern int Chbevx(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, int kd, System.IntPtr ab, int ldab, System.IntPtr q, int ldq, float vl, float vu, int il, int iu, float abstol, int* m, float* w, System.IntPtr z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chbevx_work")]
            internal static extern int ChbevxWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, int kd, System.IntPtr ab, int ldab, System.IntPtr q, int ldq, float vl, float vu, int il, int iu, float abstol, int* m, float* w, System.IntPtr z, int ldz, System.IntPtr work, float* rwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chbgst")]
            internal static extern int Chbgst(BLAS.LAYOUT matrixLayout, sbyte vect, sbyte uplo, int n, int ka, int kb, System.IntPtr ab, int ldab, System.IntPtr bb, int ldbb, System.IntPtr x, int ldx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chbgst_work")]
            internal static extern int ChbgstWork(BLAS.LAYOUT matrixLayout, sbyte vect, sbyte uplo, int n, int ka, int kb, System.IntPtr ab, int ldab, System.IntPtr bb, int ldbb, System.IntPtr x, int ldx, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chbgv")]
            internal static extern int Chbgv(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int ka, int kb, System.IntPtr ab, int ldab, System.IntPtr bb, int ldbb, float* w, System.IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chbgv_work")]
            internal static extern int ChbgvWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int ka, int kb, System.IntPtr ab, int ldab, System.IntPtr bb, int ldbb, float* w, System.IntPtr z, int ldz, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chbgvd")]
            internal static extern int Chbgvd(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int ka, int kb, System.IntPtr ab, int ldab, System.IntPtr bb, int ldbb, float* w, System.IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chbgvd_work")]
            internal static extern int ChbgvdWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int ka, int kb, System.IntPtr ab, int ldab, System.IntPtr bb, int ldbb, float* w, System.IntPtr z, int ldz, System.IntPtr work, int lwork, float* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chbgvx")]
            internal static extern int Chbgvx(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, int ka, int kb, System.IntPtr ab, int ldab, System.IntPtr bb, int ldbb, System.IntPtr q, int ldq, float vl, float vu, int il, int iu, float abstol, int* m, float* w, System.IntPtr z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chbgvx_work")]
            internal static extern int ChbgvxWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, int ka, int kb, System.IntPtr ab, int ldab, System.IntPtr bb, int ldbb, System.IntPtr q, int ldq, float vl, float vu, int il, int iu, float abstol, int* m, float* w, System.IntPtr z, int ldz, System.IntPtr work, float* rwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chbtrd")]
            internal static extern int Chbtrd(BLAS.LAYOUT matrixLayout, sbyte vect, sbyte uplo, int n, int kd, System.IntPtr ab, int ldab, float* d, float* e, System.IntPtr q, int ldq);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chbtrd_work")]
            internal static extern int ChbtrdWork(BLAS.LAYOUT matrixLayout, sbyte vect, sbyte uplo, int n, int kd, System.IntPtr ab, int ldab, float* d, float* e, System.IntPtr q, int ldq, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_checon")]
            internal static extern int Checon(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_checon_work")]
            internal static extern int CheconWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv, float anorm, float* rcond, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cheequb")]
            internal static extern int Cheequb(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, float* s, float* scond, float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cheequb_work")]
            internal static extern int CheequbWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, float* s, float* scond, float* amax, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cheev")]
            internal static extern int Cheev(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, System.IntPtr a, int lda, float* w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cheev_work")]
            internal static extern int CheevWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, System.IntPtr a, int lda, float* w, System.IntPtr work, int lwork, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cheevd")]
            internal static extern int Cheevd(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, System.IntPtr a, int lda, float* w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cheevd_work")]
            internal static extern int CheevdWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, System.IntPtr a, int lda, float* w, System.IntPtr work, int lwork, float* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cheevr")]
            internal static extern int Cheevr(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, System.IntPtr a, int lda, float vl, float vu, int il, int iu, float abstol, int* m, float* w, System.IntPtr z, int ldz, int* isuppz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cheevr_work")]
            internal static extern int CheevrWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, System.IntPtr a, int lda, float vl, float vu, int il, int iu, float abstol, int* m, float* w, System.IntPtr z, int ldz, int* isuppz, System.IntPtr work, int lwork, float* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cheevx")]
            internal static extern int Cheevx(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, System.IntPtr a, int lda, float vl, float vu, int il, int iu, float abstol, int* m, float* w, System.IntPtr z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cheevx_work")]
            internal static extern int CheevxWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, System.IntPtr a, int lda, float vl, float vu, int il, int iu, float abstol, int* m, float* w, System.IntPtr z, int ldz, System.IntPtr work, int lwork, float* rwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chegst")]
            internal static extern int Chegst(BLAS.LAYOUT matrixLayout, int itype, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chegst_work")]
            internal static extern int ChegstWork(BLAS.LAYOUT matrixLayout, int itype, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chegv")]
            internal static extern int Chegv(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, float* w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chegv_work")]
            internal static extern int ChegvWork(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, float* w, System.IntPtr work, int lwork, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chegvd")]
            internal static extern int Chegvd(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, float* w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chegvd_work")]
            internal static extern int ChegvdWork(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, float* w, System.IntPtr work, int lwork, float* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chegvx")]
            internal static extern int Chegvx(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte range, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, float vl, float vu, int il, int iu, float abstol, int* m, float* w, System.IntPtr z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chegvx_work")]
            internal static extern int ChegvxWork(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte range, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, float vl, float vu, int il, int iu, float abstol, int* m, float* w, System.IntPtr z, int ldz, System.IntPtr work, int lwork, float* rwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cherfs")]
            internal static extern int Cherfs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, int* ipiv, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cherfs_work")]
            internal static extern int CherfsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, int* ipiv, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* ferr, float* berr, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cherfsx")]
            internal static extern int Cherfsx(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte equed, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, int* ipiv, float* s, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* rcond, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cherfsx_work")]
            internal static extern int CherfsxWork(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte equed, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, int* ipiv, float* s, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* rcond, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chesv")]
            internal static extern int Chesv(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chesv_work")]
            internal static extern int ChesvWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chesvx")]
            internal static extern int Chesvx(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, int* ipiv, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* rcond, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chesvx_work")]
            internal static extern int ChesvxWork(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, int* ipiv, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* rcond, float* ferr, float* berr, System.IntPtr work, int lwork, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chesvxx")]
            internal static extern int Chesvxx(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, int* ipiv, sbyte* equed, float* s, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* rcond, float* rpvgrw, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chesvxx_work")]
            internal static extern int ChesvxxWork(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, int* ipiv, sbyte* equed, float* s, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* rcond, float* rpvgrw, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cheswapr")]
            internal static extern int Cheswapr(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int i1, int i2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cheswapr_work")]
            internal static extern int CheswaprWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int i1, int i2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chetrd")]
            internal static extern int Chetrd(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, float* d, float* e, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chetrd_work")]
            internal static extern int ChetrdWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, float* d, float* e, System.IntPtr tau, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chetrf")]
            internal static extern int Chetrf(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chetrf_rook")]
            internal static extern int ChetrfRook(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chetrf_rook_work")]
            internal static extern int ChetrfRookWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chetrf_work")]
            internal static extern int ChetrfWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chetri")]
            internal static extern int Chetri(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chetri2")]
            internal static extern int Chetri2(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chetri2_work")]
            internal static extern int Chetri2Work(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chetri2x")]
            internal static extern int Chetri2x(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv, int nb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chetri2x_work")]
            internal static extern int Chetri2xWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv, System.IntPtr work, int nb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chetri_work")]
            internal static extern int ChetriWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chetrs")]
            internal static extern int Chetrs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chetrs2")]
            internal static extern int Chetrs2(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chetrs2_work")]
            internal static extern int Chetrs2Work(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chetrs_rook")]
            internal static extern int ChetrsRook(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chetrs_rook_work")]
            internal static extern int ChetrsRookWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chetrs_work")]
            internal static extern int ChetrsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chfrk")]
            internal static extern int Chfrk(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, BLAS.TRANS trans, int n, int k, float alpha, System.IntPtr a, int lda, float beta, System.IntPtr c);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chfrk_work")]
            internal static extern int ChfrkWork(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, BLAS.TRANS trans, int n, int k, float alpha, System.IntPtr a, int lda, float beta, System.IntPtr c);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chgeqz")]
            internal static extern int Chgeqz(BLAS.LAYOUT matrixLayout, sbyte job, sbyte compq, sbyte compz, int n, int ilo, int ihi, System.IntPtr h, int ldh, System.IntPtr t, int ldt, System.IntPtr alpha, System.IntPtr beta, System.IntPtr q, int ldq, System.IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chgeqz_work")]
            internal static extern int ChgeqzWork(BLAS.LAYOUT matrixLayout, sbyte job, sbyte compq, sbyte compz, int n, int ilo, int ihi, System.IntPtr h, int ldh, System.IntPtr t, int ldt, System.IntPtr alpha, System.IntPtr beta, System.IntPtr q, int ldq, System.IntPtr z, int ldz, System.IntPtr work, int lwork, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chpcon")]
            internal static extern int Chpcon(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, int* ipiv, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chpcon_work")]
            internal static extern int ChpconWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, int* ipiv, float anorm, float* rcond, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chpev")]
            internal static extern int Chpev(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, System.IntPtr ap, float* w, System.IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chpev_work")]
            internal static extern int ChpevWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, System.IntPtr ap, float* w, System.IntPtr z, int ldz, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chpevd")]
            internal static extern int Chpevd(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, System.IntPtr ap, float* w, System.IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chpevd_work")]
            internal static extern int ChpevdWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, System.IntPtr ap, float* w, System.IntPtr z, int ldz, System.IntPtr work, int lwork, float* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chpevx")]
            internal static extern int Chpevx(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, System.IntPtr ap, float vl, float vu, int il, int iu, float abstol, int* m, float* w, System.IntPtr z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chpevx_work")]
            internal static extern int ChpevxWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, System.IntPtr ap, float vl, float vu, int il, int iu, float abstol, int* m, float* w, System.IntPtr z, int ldz, System.IntPtr work, float* rwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chpgst")]
            internal static extern int Chpgst(BLAS.LAYOUT matrixLayout, int itype, sbyte uplo, int n, System.IntPtr ap, System.IntPtr bp);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chpgst_work")]
            internal static extern int ChpgstWork(BLAS.LAYOUT matrixLayout, int itype, sbyte uplo, int n, System.IntPtr ap, System.IntPtr bp);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chpgv")]
            internal static extern int Chpgv(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, System.IntPtr ap, System.IntPtr bp, float* w, System.IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chpgv_work")]
            internal static extern int ChpgvWork(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, System.IntPtr ap, System.IntPtr bp, float* w, System.IntPtr z, int ldz, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chpgvd")]
            internal static extern int Chpgvd(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, System.IntPtr ap, System.IntPtr bp, float* w, System.IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chpgvd_work")]
            internal static extern int ChpgvdWork(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, System.IntPtr ap, System.IntPtr bp, float* w, System.IntPtr z, int ldz, System.IntPtr work, int lwork, float* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chpgvx")]
            internal static extern int Chpgvx(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte range, sbyte uplo, int n, System.IntPtr ap, System.IntPtr bp, float vl, float vu, int il, int iu, float abstol, int* m, float* w, System.IntPtr z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chpgvx_work")]
            internal static extern int ChpgvxWork(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte range, sbyte uplo, int n, System.IntPtr ap, System.IntPtr bp, float vl, float vu, int il, int iu, float abstol, int* m, float* w, System.IntPtr z, int ldz, System.IntPtr work, float* rwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chprfs")]
            internal static extern int Chprfs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr ap, System.IntPtr afp, int* ipiv, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chprfs_work")]
            internal static extern int ChprfsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr ap, System.IntPtr afp, int* ipiv, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* ferr, float* berr, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chpsv")]
            internal static extern int Chpsv(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr ap, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chpsv_work")]
            internal static extern int ChpsvWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr ap, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chpsvx")]
            internal static extern int Chpsvx(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, System.IntPtr ap, System.IntPtr afp, int* ipiv, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* rcond, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chpsvx_work")]
            internal static extern int ChpsvxWork(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, System.IntPtr ap, System.IntPtr afp, int* ipiv, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* rcond, float* ferr, float* berr, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chptrd")]
            internal static extern int Chptrd(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, float* d, float* e, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chptrd_work")]
            internal static extern int ChptrdWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, float* d, float* e, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chptrf")]
            internal static extern int Chptrf(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chptrf_work")]
            internal static extern int ChptrfWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chptri")]
            internal static extern int Chptri(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chptri_work")]
            internal static extern int ChptriWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, int* ipiv, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chptrs")]
            internal static extern int Chptrs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr ap, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chptrs_work")]
            internal static extern int ChptrsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr ap, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chsein")]
            internal static extern int Chsein(BLAS.LAYOUT matrixLayout, sbyte job, sbyte eigsrc, sbyte initv, int* select, int n, System.IntPtr h, int ldh, System.IntPtr w, System.IntPtr vl, int ldvl, System.IntPtr vr, int ldvr, int mm, int* m, int* ifaill, int* ifailr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chsein_work")]
            internal static extern int ChseinWork(BLAS.LAYOUT matrixLayout, sbyte job, sbyte eigsrc, sbyte initv, int* select, int n, System.IntPtr h, int ldh, System.IntPtr w, System.IntPtr vl, int ldvl, System.IntPtr vr, int ldvr, int mm, int* m, System.IntPtr work, float* rwork, int* ifaill, int* ifailr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chseqr")]
            internal static extern int Chseqr(BLAS.LAYOUT matrixLayout, sbyte job, sbyte compz, int n, int ilo, int ihi, System.IntPtr h, int ldh, System.IntPtr w, System.IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chseqr_work")]
            internal static extern int ChseqrWork(BLAS.LAYOUT matrixLayout, sbyte job, sbyte compz, int n, int ilo, int ihi, System.IntPtr h, int ldh, System.IntPtr w, System.IntPtr z, int ldz, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_clacgv")]
            internal static extern int Clacgv(int n, System.IntPtr x, int incx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_clacgv_work")]
            internal static extern int ClacgvWork(int n, System.IntPtr x, int incx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_clacn2")]
            internal static extern int Clacn2(int n, System.IntPtr v, System.IntPtr x, float* est, int* kase, int* isave);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_clacn2_work")]
            internal static extern int Clacn2Work(int n, System.IntPtr v, System.IntPtr x, float* est, int* kase, int* isave);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_clacp2")]
            internal static extern int Clacp2(BLAS.LAYOUT matrixLayout, sbyte uplo, int m, int n, float* a, int lda, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_clacp2_work")]
            internal static extern int Clacp2Work(BLAS.LAYOUT matrixLayout, sbyte uplo, int m, int n, float* a, int lda, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_clacpy")]
            internal static extern int Clacpy(BLAS.LAYOUT matrixLayout, sbyte uplo, int m, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_clacpy_work")]
            internal static extern int ClacpyWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int m, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_clag2z")]
            internal static extern int Clag2z(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr sa, int ldsa, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_clag2z_work")]
            internal static extern int Clag2zWork(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr sa, int ldsa, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_clagge")]
            internal static extern int Clagge(BLAS.LAYOUT matrixLayout, int m, int n, int kl, int ku, float* d, System.IntPtr a, int lda, int* iseed);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_clagge_work")]
            internal static extern int ClaggeWork(BLAS.LAYOUT matrixLayout, int m, int n, int kl, int ku, float* d, System.IntPtr a, int lda, int* iseed, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_claghe")]
            internal static extern int Claghe(BLAS.LAYOUT matrixLayout, int n, int k, float* d, System.IntPtr a, int lda, int* iseed);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_claghe_work")]
            internal static extern int ClagheWork(BLAS.LAYOUT matrixLayout, int n, int k, float* d, System.IntPtr a, int lda, int* iseed, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_clagsy")]
            internal static extern int Clagsy(BLAS.LAYOUT matrixLayout, int n, int k, float* d, System.IntPtr a, int lda, int* iseed);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_clagsy_work")]
            internal static extern int ClagsyWork(BLAS.LAYOUT matrixLayout, int n, int k, float* d, System.IntPtr a, int lda, int* iseed, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_clapmr")]
            internal static extern int Clapmr(BLAS.LAYOUT matrixLayout, int forwrd, int m, int n, System.IntPtr x, int ldx, int* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_clapmr_work")]
            internal static extern int ClapmrWork(BLAS.LAYOUT matrixLayout, int forwrd, int m, int n, System.IntPtr x, int ldx, int* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_clapmt")]
            internal static extern int Clapmt(BLAS.LAYOUT matrixLayout, int forwrd, int m, int n, System.IntPtr x, int ldx, int* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_clapmt_work")]
            internal static extern int ClapmtWork(BLAS.LAYOUT matrixLayout, int forwrd, int m, int n, System.IntPtr x, int ldx, int* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_clarfb")]
            internal static extern int Clarfb(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, sbyte direct, sbyte storev, int m, int n, int k, System.IntPtr v, int ldv, System.IntPtr t, int ldt, System.IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_clarfb_work")]
            internal static extern int ClarfbWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, sbyte direct, sbyte storev, int m, int n, int k, System.IntPtr v, int ldv, System.IntPtr t, int ldt, System.IntPtr c, int ldc, System.IntPtr work, int ldwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_clarfg")]
            internal static extern int Clarfg(int n, System.IntPtr alpha, System.IntPtr x, int incx, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_clarfg_work")]
            internal static extern int ClarfgWork(int n, System.IntPtr alpha, System.IntPtr x, int incx, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_clarft")]
            internal static extern int Clarft(BLAS.LAYOUT matrixLayout, sbyte direct, sbyte storev, int n, int k, System.IntPtr v, int ldv, System.IntPtr tau, System.IntPtr t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_clarft_work")]
            internal static extern int ClarftWork(BLAS.LAYOUT matrixLayout, sbyte direct, sbyte storev, int n, int k, System.IntPtr v, int ldv, System.IntPtr tau, System.IntPtr t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_clarfx")]
            internal static extern int Clarfx(BLAS.LAYOUT matrixLayout, sbyte side, int m, int n, System.IntPtr v, ComplexFloat tau, System.IntPtr c, int ldc, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_clarfx_work")]
            internal static extern int ClarfxWork(BLAS.LAYOUT matrixLayout, sbyte side, int m, int n, System.IntPtr v, ComplexFloat tau, System.IntPtr c, int ldc, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_clarnv")]
            internal static extern int Clarnv(int idist, int* iseed, int n, System.IntPtr x);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_clarnv_work")]
            internal static extern int ClarnvWork(int idist, int* iseed, int n, System.IntPtr x);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_clascl")]
            internal static extern int Clascl(BLAS.LAYOUT matrixLayout, sbyte type, int kl, int ku, float cfrom, float cto, int m, int n, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_clascl_work")]
            internal static extern int ClasclWork(BLAS.LAYOUT matrixLayout, sbyte type, int kl, int ku, float cfrom, float cto, int m, int n, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_claset")]
            internal static extern int Claset(BLAS.LAYOUT matrixLayout, sbyte uplo, int m, int n, ComplexFloat alpha, ComplexFloat beta, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_claset_work")]
            internal static extern int ClasetWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int m, int n, ComplexFloat alpha, ComplexFloat beta, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_claswp")]
            internal static extern int Claswp(BLAS.LAYOUT matrixLayout, int n, System.IntPtr a, int lda, int k1, int k2, int* ipiv, int incx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_claswp_work")]
            internal static extern int ClaswpWork(BLAS.LAYOUT matrixLayout, int n, System.IntPtr a, int lda, int k1, int k2, int* ipiv, int incx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_clatms")]
            internal static extern int Clatms(BLAS.LAYOUT matrixLayout, int m, int n, sbyte dist, int* iseed, sbyte sym, float* d, int mode, float cond, float dmax, int kl, int ku, sbyte pack, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_clatms_work")]
            internal static extern int ClatmsWork(BLAS.LAYOUT matrixLayout, int m, int n, sbyte dist, int* iseed, sbyte sym, float* d, int mode, float cond, float dmax, int kl, int ku, sbyte pack, System.IntPtr a, int lda, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_clauum")]
            internal static extern int Clauum(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_clauum_work")]
            internal static extern int ClauumWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cpbcon")]
            internal static extern int Cpbcon(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, System.IntPtr ab, int ldab, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cpbcon_work")]
            internal static extern int CpbconWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, System.IntPtr ab, int ldab, float anorm, float* rcond, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cpbequ")]
            internal static extern int Cpbequ(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, System.IntPtr ab, int ldab, float* s, float* scond, float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cpbequ_work")]
            internal static extern int CpbequWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, System.IntPtr ab, int ldab, float* s, float* scond, float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cpbrfs")]
            internal static extern int Cpbrfs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, int nrhs, System.IntPtr ab, int ldab, System.IntPtr afb, int ldafb, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cpbrfs_work")]
            internal static extern int CpbrfsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, int nrhs, System.IntPtr ab, int ldab, System.IntPtr afb, int ldafb, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* ferr, float* berr, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cpbstf")]
            internal static extern int Cpbstf(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kb, System.IntPtr bb, int ldbb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cpbstf_work")]
            internal static extern int CpbstfWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kb, System.IntPtr bb, int ldbb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cpbsv")]
            internal static extern int Cpbsv(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, int nrhs, System.IntPtr ab, int ldab, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cpbsv_work")]
            internal static extern int CpbsvWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, int nrhs, System.IntPtr ab, int ldab, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cpbsvx")]
            internal static extern int Cpbsvx(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int kd, int nrhs, System.IntPtr ab, int ldab, System.IntPtr afb, int ldafb, sbyte* equed, float* s, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* rcond, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cpbsvx_work")]
            internal static extern int CpbsvxWork(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int kd, int nrhs, System.IntPtr ab, int ldab, System.IntPtr afb, int ldafb, sbyte* equed, float* s, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* rcond, float* ferr, float* berr, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cpbtrf")]
            internal static extern int Cpbtrf(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, System.IntPtr ab, int ldab);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cpbtrf_work")]
            internal static extern int CpbtrfWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, System.IntPtr ab, int ldab);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cpbtrs")]
            internal static extern int Cpbtrs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, int nrhs, System.IntPtr ab, int ldab, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cpbtrs_work")]
            internal static extern int CpbtrsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, int nrhs, System.IntPtr ab, int ldab, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cpftrf")]
            internal static extern int Cpftrf(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, System.IntPtr a);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cpftrf_work")]
            internal static extern int CpftrfWork(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, System.IntPtr a);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cpftri")]
            internal static extern int Cpftri(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, System.IntPtr a);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cpftri_work")]
            internal static extern int CpftriWork(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, System.IntPtr a);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cpftrs")]
            internal static extern int Cpftrs(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, int nrhs, System.IntPtr a, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cpftrs_work")]
            internal static extern int CpftrsWork(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, int nrhs, System.IntPtr a, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cpocon")]
            internal static extern int Cpocon(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cpocon_work")]
            internal static extern int CpoconWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, float anorm, float* rcond, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cpoequ")]
            internal static extern int Cpoequ(BLAS.LAYOUT matrixLayout, int n, System.IntPtr a, int lda, float* s, float* scond, float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cpoequ_work")]
            internal static extern int CpoequWork(BLAS.LAYOUT matrixLayout, int n, System.IntPtr a, int lda, float* s, float* scond, float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cpoequb")]
            internal static extern int Cpoequb(BLAS.LAYOUT matrixLayout, int n, System.IntPtr a, int lda, float* s, float* scond, float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cpoequb_work")]
            internal static extern int CpoequbWork(BLAS.LAYOUT matrixLayout, int n, System.IntPtr a, int lda, float* s, float* scond, float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cporfs")]
            internal static extern int Cporfs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cporfs_work")]
            internal static extern int CporfsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* ferr, float* berr, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cporfsx")]
            internal static extern int Cporfsx(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte equed, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, float* s, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* rcond, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cporfsx_work")]
            internal static extern int CporfsxWork(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte equed, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, float* s, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* rcond, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cposv")]
            internal static extern int Cposv(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cposv_work")]
            internal static extern int CposvWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cposvx")]
            internal static extern int Cposvx(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, sbyte* equed, float* s, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* rcond, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cposvx_work")]
            internal static extern int CposvxWork(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, sbyte* equed, float* s, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* rcond, float* ferr, float* berr, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cposvxx")]
            internal static extern int Cposvxx(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, sbyte* equed, float* s, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* rcond, float* rpvgrw, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cposvxx_work")]
            internal static extern int CposvxxWork(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, sbyte* equed, float* s, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* rcond, float* rpvgrw, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cpotrf")]
            internal static extern int Cpotrf(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cpotrf2")]
            internal static extern int Cpotrf2(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cpotrf2_work")]
            internal static extern int Cpotrf2Work(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cpotrf_work")]
            internal static extern int CpotrfWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cpotri")]
            internal static extern int Cpotri(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cpotri_work")]
            internal static extern int CpotriWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cpotrs")]
            internal static extern int Cpotrs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cpotrs_work")]
            internal static extern int CpotrsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cppcon")]
            internal static extern int Cppcon(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cppcon_work")]
            internal static extern int CppconWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, float anorm, float* rcond, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cppequ")]
            internal static extern int Cppequ(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, float* s, float* scond, float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cppequ_work")]
            internal static extern int CppequWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, float* s, float* scond, float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cpprfs")]
            internal static extern int Cpprfs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr ap, System.IntPtr afp, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cpprfs_work")]
            internal static extern int CpprfsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr ap, System.IntPtr afp, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* ferr, float* berr, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cppsv")]
            internal static extern int Cppsv(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr ap, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cppsv_work")]
            internal static extern int CppsvWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr ap, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cppsvx")]
            internal static extern int Cppsvx(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, System.IntPtr ap, System.IntPtr afp, sbyte* equed, float* s, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* rcond, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cppsvx_work")]
            internal static extern int CppsvxWork(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, System.IntPtr ap, System.IntPtr afp, sbyte* equed, float* s, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* rcond, float* ferr, float* berr, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cpptrf")]
            internal static extern int Cpptrf(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cpptrf_work")]
            internal static extern int CpptrfWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cpptri")]
            internal static extern int Cpptri(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cpptri_work")]
            internal static extern int CpptriWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cpptrs")]
            internal static extern int Cpptrs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr ap, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cpptrs_work")]
            internal static extern int CpptrsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr ap, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cpstrf")]
            internal static extern int Cpstrf(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* piv, int* rank, float tol);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cpstrf_work")]
            internal static extern int CpstrfWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* piv, int* rank, float tol, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cptcon")]
            internal static extern int Cptcon(int n, float* d, System.IntPtr e, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cptcon_work")]
            internal static extern int CptconWork(int n, float* d, System.IntPtr e, float anorm, float* rcond, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cpteqr")]
            internal static extern int Cpteqr(BLAS.LAYOUT matrixLayout, sbyte compz, int n, float* d, float* e, System.IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cpteqr_work")]
            internal static extern int CpteqrWork(BLAS.LAYOUT matrixLayout, sbyte compz, int n, float* d, float* e, System.IntPtr z, int ldz, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cptrfs")]
            internal static extern int Cptrfs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* d, System.IntPtr e, float* df, System.IntPtr ef, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cptrfs_work")]
            internal static extern int CptrfsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* d, System.IntPtr e, float* df, System.IntPtr ef, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* ferr, float* berr, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cptsv")]
            internal static extern int Cptsv(BLAS.LAYOUT matrixLayout, int n, int nrhs, float* d, System.IntPtr e, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cptsv_work")]
            internal static extern int CptsvWork(BLAS.LAYOUT matrixLayout, int n, int nrhs, float* d, System.IntPtr e, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cptsvx")]
            internal static extern int Cptsvx(BLAS.LAYOUT matrixLayout, sbyte fact, int n, int nrhs, float* d, System.IntPtr e, float* df, System.IntPtr ef, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* rcond, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cptsvx_work")]
            internal static extern int CptsvxWork(BLAS.LAYOUT matrixLayout, sbyte fact, int n, int nrhs, float* d, System.IntPtr e, float* df, System.IntPtr ef, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* rcond, float* ferr, float* berr, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cpttrf")]
            internal static extern int Cpttrf(int n, float* d, System.IntPtr e);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cpttrf_work")]
            internal static extern int CpttrfWork(int n, float* d, System.IntPtr e);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cpttrs")]
            internal static extern int Cpttrs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* d, System.IntPtr e, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cpttrs_work")]
            internal static extern int CpttrsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* d, System.IntPtr e, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cspcon")]
            internal static extern int Cspcon(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, int* ipiv, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cspcon_work")]
            internal static extern int CspconWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, int* ipiv, float anorm, float* rcond, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_csprfs")]
            internal static extern int Csprfs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr ap, System.IntPtr afp, int* ipiv, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_csprfs_work")]
            internal static extern int CsprfsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr ap, System.IntPtr afp, int* ipiv, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* ferr, float* berr, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cspsv")]
            internal static extern int Cspsv(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr ap, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cspsv_work")]
            internal static extern int CspsvWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr ap, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cspsvx")]
            internal static extern int Cspsvx(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, System.IntPtr ap, System.IntPtr afp, int* ipiv, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* rcond, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cspsvx_work")]
            internal static extern int CspsvxWork(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, System.IntPtr ap, System.IntPtr afp, int* ipiv, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* rcond, float* ferr, float* berr, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_csptrf")]
            internal static extern int Csptrf(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_csptrf_work")]
            internal static extern int CsptrfWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_csptri")]
            internal static extern int Csptri(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_csptri_work")]
            internal static extern int CsptriWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, int* ipiv, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_csptrs")]
            internal static extern int Csptrs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr ap, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_csptrs_work")]
            internal static extern int CsptrsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr ap, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cstedc")]
            internal static extern int Cstedc(BLAS.LAYOUT matrixLayout, sbyte compz, int n, float* d, float* e, System.IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cstedc_work")]
            internal static extern int CstedcWork(BLAS.LAYOUT matrixLayout, sbyte compz, int n, float* d, float* e, System.IntPtr z, int ldz, System.IntPtr work, int lwork, float* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cstegr")]
            internal static extern int Cstegr(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, int n, float* d, float* e, float vl, float vu, int il, int iu, float abstol, int* m, float* w, System.IntPtr z, int ldz, int* isuppz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cstegr_work")]
            internal static extern int CstegrWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, int n, float* d, float* e, float vl, float vu, int il, int iu, float abstol, int* m, float* w, System.IntPtr z, int ldz, int* isuppz, float* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cstein")]
            internal static extern int Cstein(BLAS.LAYOUT matrixLayout, int n, float* d, float* e, int m, float* w, int* iblock, int* isplit, System.IntPtr z, int ldz, int* ifailv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cstein_work")]
            internal static extern int CsteinWork(BLAS.LAYOUT matrixLayout, int n, float* d, float* e, int m, float* w, int* iblock, int* isplit, System.IntPtr z, int ldz, float* work, int* iwork, int* ifailv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cstemr")]
            internal static extern int Cstemr(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, int n, float* d, float* e, float vl, float vu, int il, int iu, int* m, float* w, System.IntPtr z, int ldz, int nzc, int* isuppz, int* tryrac);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cstemr_work")]
            internal static extern int CstemrWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, int n, float* d, float* e, float vl, float vu, int il, int iu, int* m, float* w, System.IntPtr z, int ldz, int nzc, int* isuppz, int* tryrac, float* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_csteqr")]
            internal static extern int Csteqr(BLAS.LAYOUT matrixLayout, sbyte compz, int n, float* d, float* e, System.IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_csteqr_work")]
            internal static extern int CsteqrWork(BLAS.LAYOUT matrixLayout, sbyte compz, int n, float* d, float* e, System.IntPtr z, int ldz, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_csycon")]
            internal static extern int Csycon(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_csycon_work")]
            internal static extern int CsyconWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv, float anorm, float* rcond, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_csyconv")]
            internal static extern int Csyconv(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte way, int n, System.IntPtr a, int lda, int* ipiv, System.IntPtr e);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_csyconv_work")]
            internal static extern int CsyconvWork(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte way, int n, System.IntPtr a, int lda, int* ipiv, System.IntPtr e);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_csyequb")]
            internal static extern int Csyequb(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, float* s, float* scond, float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_csyequb_work")]
            internal static extern int CsyequbWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, float* s, float* scond, float* amax, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_csyr")]
            internal static extern int Csyr(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, ComplexFloat alpha, System.IntPtr x, int incx, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_csyr_work")]
            internal static extern int CsyrWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, ComplexFloat alpha, System.IntPtr x, int incx, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_csyrfs")]
            internal static extern int Csyrfs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, int* ipiv, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_csyrfs_work")]
            internal static extern int CsyrfsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, int* ipiv, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* ferr, float* berr, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_csyrfsx")]
            internal static extern int Csyrfsx(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte equed, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, int* ipiv, float* s, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* rcond, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_csyrfsx_work")]
            internal static extern int CsyrfsxWork(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte equed, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, int* ipiv, float* s, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* rcond, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_csysv")]
            internal static extern int Csysv(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_csysv_rook")]
            internal static extern int CsysvRook(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_csysv_rook_work")]
            internal static extern int CsysvRookWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_csysv_work")]
            internal static extern int CsysvWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_csysvx")]
            internal static extern int Csysvx(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, int* ipiv, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* rcond, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_csysvx_work")]
            internal static extern int CsysvxWork(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, int* ipiv, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* rcond, float* ferr, float* berr, System.IntPtr work, int lwork, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_csysvxx")]
            internal static extern int Csysvxx(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, int* ipiv, sbyte* equed, float* s, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* rcond, float* rpvgrw, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_csysvxx_work")]
            internal static extern int CsysvxxWork(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, int* ipiv, sbyte* equed, float* s, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* rcond, float* rpvgrw, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_csyswapr")]
            internal static extern int Csyswapr(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int i1, int i2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_csyswapr_work")]
            internal static extern int CsyswaprWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int i1, int i2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_csytrf")]
            internal static extern int Csytrf(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_csytrf_rook")]
            internal static extern int CsytrfRook(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_csytrf_rook_work")]
            internal static extern int CsytrfRookWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_csytrf_work")]
            internal static extern int CsytrfWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_csytri")]
            internal static extern int Csytri(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_csytri2")]
            internal static extern int Csytri2(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_csytri2_work")]
            internal static extern int Csytri2Work(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_csytri2x")]
            internal static extern int Csytri2x(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv, int nb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_csytri2x_work")]
            internal static extern int Csytri2xWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv, System.IntPtr work, int nb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_csytri_work")]
            internal static extern int CsytriWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_csytrs")]
            internal static extern int Csytrs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_csytrs2")]
            internal static extern int Csytrs2(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_csytrs2_work")]
            internal static extern int Csytrs2Work(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_csytrs_rook")]
            internal static extern int CsytrsRook(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_csytrs_rook_work")]
            internal static extern int CsytrsRookWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_csytrs_work")]
            internal static extern int CsytrsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ctbcon")]
            internal static extern int Ctbcon(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int n, int kd, System.IntPtr ab, int ldab, float* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ctbcon_work")]
            internal static extern int CtbconWork(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int n, int kd, System.IntPtr ab, int ldab, float* rcond, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ctbrfs")]
            internal static extern int Ctbrfs(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int kd, int nrhs, System.IntPtr ab, int ldab, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ctbrfs_work")]
            internal static extern int CtbrfsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int kd, int nrhs, System.IntPtr ab, int ldab, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* ferr, float* berr, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ctbtrs")]
            internal static extern int Ctbtrs(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int kd, int nrhs, System.IntPtr ab, int ldab, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ctbtrs_work")]
            internal static extern int CtbtrsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int kd, int nrhs, System.IntPtr ab, int ldab, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ctfsm")]
            internal static extern int Ctfsm(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte side, sbyte uplo, BLAS.TRANS trans, sbyte diag, int m, int n, ComplexFloat alpha, System.IntPtr a, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ctfsm_work")]
            internal static extern int CtfsmWork(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte side, sbyte uplo, BLAS.TRANS trans, sbyte diag, int m, int n, ComplexFloat alpha, System.IntPtr a, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ctftri")]
            internal static extern int Ctftri(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, sbyte diag, int n, System.IntPtr a);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ctftri_work")]
            internal static extern int CtftriWork(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, sbyte diag, int n, System.IntPtr a);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ctfttp")]
            internal static extern int Ctfttp(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, System.IntPtr arf, System.IntPtr ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ctfttp_work")]
            internal static extern int CtfttpWork(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, System.IntPtr arf, System.IntPtr ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ctfttr")]
            internal static extern int Ctfttr(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, System.IntPtr arf, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ctfttr_work")]
            internal static extern int CtfttrWork(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, System.IntPtr arf, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ctgevc")]
            internal static extern int Ctgevc(BLAS.LAYOUT matrixLayout, sbyte side, sbyte howmny, int* select, int n, System.IntPtr s, int lds, System.IntPtr p, int ldp, System.IntPtr vl, int ldvl, System.IntPtr vr, int ldvr, int mm, int* m);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ctgevc_work")]
            internal static extern int CtgevcWork(BLAS.LAYOUT matrixLayout, sbyte side, sbyte howmny, int* select, int n, System.IntPtr s, int lds, System.IntPtr p, int ldp, System.IntPtr vl, int ldvl, System.IntPtr vr, int ldvr, int mm, int* m, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ctgexc")]
            internal static extern int Ctgexc(BLAS.LAYOUT matrixLayout, int wantq, int wantz, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr q, int ldq, System.IntPtr z, int ldz, int ifst, int ilst);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ctgexc_work")]
            internal static extern int CtgexcWork(BLAS.LAYOUT matrixLayout, int wantq, int wantz, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr q, int ldq, System.IntPtr z, int ldz, int ifst, int ilst);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ctgsen")]
            internal static extern int Ctgsen(BLAS.LAYOUT matrixLayout, int ijob, int wantq, int wantz, int* select, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr alpha, System.IntPtr beta, System.IntPtr q, int ldq, System.IntPtr z, int ldz, int* m, float* pl, float* pr, float* dif);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ctgsen_work")]
            internal static extern int CtgsenWork(BLAS.LAYOUT matrixLayout, int ijob, int wantq, int wantz, int* select, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr alpha, System.IntPtr beta, System.IntPtr q, int ldq, System.IntPtr z, int ldz, int* m, float* pl, float* pr, float* dif, System.IntPtr work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ctgsja")]
            internal static extern int Ctgsja(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, int k, int l, System.IntPtr a, int lda, System.IntPtr b, int ldb, float tola, float tolb, float* alpha, float* beta, System.IntPtr u, int ldu, System.IntPtr v, int ldv, System.IntPtr q, int ldq, int* ncycle);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ctgsja_work")]
            internal static extern int CtgsjaWork(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, int k, int l, System.IntPtr a, int lda, System.IntPtr b, int ldb, float tola, float tolb, float* alpha, float* beta, System.IntPtr u, int ldu, System.IntPtr v, int ldv, System.IntPtr q, int ldq, System.IntPtr work, int* ncycle);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ctgsna")]
            internal static extern int Ctgsna(BLAS.LAYOUT matrixLayout, sbyte job, sbyte howmny, int* select, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr vl, int ldvl, System.IntPtr vr, int ldvr, float* s, float* dif, int mm, int* m);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ctgsna_work")]
            internal static extern int CtgsnaWork(BLAS.LAYOUT matrixLayout, sbyte job, sbyte howmny, int* select, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr vl, int ldvl, System.IntPtr vr, int ldvr, float* s, float* dif, int mm, int* m, System.IntPtr work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ctgsyl")]
            internal static extern int Ctgsyl(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int ijob, int m, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr c, int ldc, System.IntPtr d, int ldd, System.IntPtr e, int lde, System.IntPtr f, int ldf, float* scale, float* dif);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ctgsyl_work")]
            internal static extern int CtgsylWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int ijob, int m, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr c, int ldc, System.IntPtr d, int ldd, System.IntPtr e, int lde, System.IntPtr f, int ldf, float* scale, float* dif, System.IntPtr work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ctpcon")]
            internal static extern int Ctpcon(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int n, System.IntPtr ap, float* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ctpcon_work")]
            internal static extern int CtpconWork(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int n, System.IntPtr ap, float* rcond, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ctpmqrt")]
            internal static extern int Ctpmqrt(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, int l, int nb, System.IntPtr v, int ldv, System.IntPtr t, int ldt, System.IntPtr a, int lda, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ctpmqrt_work")]
            internal static extern int CtpmqrtWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, int l, int nb, System.IntPtr v, int ldv, System.IntPtr t, int ldt, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ctpqrt")]
            internal static extern int Ctpqrt(BLAS.LAYOUT matrixLayout, int m, int n, int l, int nb, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ctpqrt2")]
            internal static extern int Ctpqrt2(BLAS.LAYOUT matrixLayout, int m, int n, int l, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ctpqrt2_work")]
            internal static extern int Ctpqrt2Work(BLAS.LAYOUT matrixLayout, int m, int n, int l, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ctpqrt_work")]
            internal static extern int CtpqrtWork(BLAS.LAYOUT matrixLayout, int m, int n, int l, int nb, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr t, int ldt, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ctprfb")]
            internal static extern int Ctprfb(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, sbyte direct, sbyte storev, int m, int n, int k, int l, System.IntPtr v, int ldv, System.IntPtr t, int ldt, System.IntPtr a, int lda, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ctprfb_work")]
            internal static extern int CtprfbWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, sbyte direct, sbyte storev, int m, int n, int k, int l, System.IntPtr v, int ldv, System.IntPtr t, int ldt, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr work, int ldwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ctprfs")]
            internal static extern int Ctprfs(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, System.IntPtr ap, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ctprfs_work")]
            internal static extern int CtprfsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, System.IntPtr ap, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* ferr, float* berr, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ctptri")]
            internal static extern int Ctptri(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte diag, int n, System.IntPtr ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ctptri_work")]
            internal static extern int CtptriWork(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte diag, int n, System.IntPtr ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ctptrs")]
            internal static extern int Ctptrs(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, System.IntPtr ap, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ctptrs_work")]
            internal static extern int CtptrsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, System.IntPtr ap, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ctpttf")]
            internal static extern int Ctpttf(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, System.IntPtr ap, System.IntPtr arf);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ctpttf_work")]
            internal static extern int CtpttfWork(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, System.IntPtr ap, System.IntPtr arf);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ctpttr")]
            internal static extern int Ctpttr(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ctpttr_work")]
            internal static extern int CtpttrWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ctrcon")]
            internal static extern int Ctrcon(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int n, System.IntPtr a, int lda, float* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ctrcon_work")]
            internal static extern int CtrconWork(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int n, System.IntPtr a, int lda, float* rcond, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ctrevc")]
            internal static extern int Ctrevc(BLAS.LAYOUT matrixLayout, sbyte side, sbyte howmny, int* select, int n, System.IntPtr t, int ldt, System.IntPtr vl, int ldvl, System.IntPtr vr, int ldvr, int mm, int* m);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ctrevc_work")]
            internal static extern int CtrevcWork(BLAS.LAYOUT matrixLayout, sbyte side, sbyte howmny, int* select, int n, System.IntPtr t, int ldt, System.IntPtr vl, int ldvl, System.IntPtr vr, int ldvr, int mm, int* m, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ctrexc")]
            internal static extern int Ctrexc(BLAS.LAYOUT matrixLayout, sbyte compq, int n, System.IntPtr t, int ldt, System.IntPtr q, int ldq, int ifst, int ilst);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ctrexc_work")]
            internal static extern int CtrexcWork(BLAS.LAYOUT matrixLayout, sbyte compq, int n, System.IntPtr t, int ldt, System.IntPtr q, int ldq, int ifst, int ilst);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ctrrfs")]
            internal static extern int Ctrrfs(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ctrrfs_work")]
            internal static extern int CtrrfsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr x, int ldx, float* ferr, float* berr, System.IntPtr work, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ctrsen")]
            internal static extern int Ctrsen(BLAS.LAYOUT matrixLayout, sbyte job, sbyte compq, int* select, int n, System.IntPtr t, int ldt, System.IntPtr q, int ldq, System.IntPtr w, int* m, float* s, float* sep);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ctrsen_work")]
            internal static extern int CtrsenWork(BLAS.LAYOUT matrixLayout, sbyte job, sbyte compq, int* select, int n, System.IntPtr t, int ldt, System.IntPtr q, int ldq, System.IntPtr w, int* m, float* s, float* sep, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ctrsna")]
            internal static extern int Ctrsna(BLAS.LAYOUT matrixLayout, sbyte job, sbyte howmny, int* select, int n, System.IntPtr t, int ldt, System.IntPtr vl, int ldvl, System.IntPtr vr, int ldvr, float* s, float* sep, int mm, int* m);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ctrsna_work")]
            internal static extern int CtrsnaWork(BLAS.LAYOUT matrixLayout, sbyte job, sbyte howmny, int* select, int n, System.IntPtr t, int ldt, System.IntPtr vl, int ldvl, System.IntPtr vr, int ldvr, float* s, float* sep, int mm, int* m, System.IntPtr work, int ldwork, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ctrsyl")]
            internal static extern int Ctrsyl(BLAS.LAYOUT matrixLayout, sbyte trana, sbyte tranb, int isgn, int m, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr c, int ldc, float* scale);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ctrsyl_work")]
            internal static extern int CtrsylWork(BLAS.LAYOUT matrixLayout, sbyte trana, sbyte tranb, int isgn, int m, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr c, int ldc, float* scale);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ctrtri")]
            internal static extern int Ctrtri(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte diag, int n, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ctrtri_work")]
            internal static extern int CtrtriWork(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte diag, int n, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ctrtrs")]
            internal static extern int Ctrtrs(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ctrtrs_work")]
            internal static extern int CtrtrsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ctrttf")]
            internal static extern int Ctrttf(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr arf);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ctrttf_work")]
            internal static extern int CtrttfWork(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr arf);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ctrttp")]
            internal static extern int Ctrttp(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ctrttp_work")]
            internal static extern int CtrttpWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ctzrzf")]
            internal static extern int Ctzrzf(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ctzrzf_work")]
            internal static extern int CtzrzfWork(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cunbdb")]
            internal static extern int Cunbdb(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, sbyte signs, int m, int p, int q, System.IntPtr x11, int ldx11, System.IntPtr x12, int ldx12, System.IntPtr x21, int ldx21, System.IntPtr x22, int ldx22, float* theta, float* phi, System.IntPtr taup1, System.IntPtr taup2, System.IntPtr tauq1, System.IntPtr tauq2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cunbdb_work")]
            internal static extern int CunbdbWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, sbyte signs, int m, int p, int q, System.IntPtr x11, int ldx11, System.IntPtr x12, int ldx12, System.IntPtr x21, int ldx21, System.IntPtr x22, int ldx22, float* theta, float* phi, System.IntPtr taup1, System.IntPtr taup2, System.IntPtr tauq1, System.IntPtr tauq2, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cuncsd")]
            internal static extern int Cuncsd(BLAS.LAYOUT matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, sbyte jobv2t, BLAS.TRANS trans, sbyte signs, int m, int p, int q, System.IntPtr x11, int ldx11, System.IntPtr x12, int ldx12, System.IntPtr x21, int ldx21, System.IntPtr x22, int ldx22, float* theta, System.IntPtr u1, int ldu1, System.IntPtr u2, int ldu2, System.IntPtr v1t, int ldv1t, System.IntPtr v2t, int ldv2t);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cuncsd2by1")]
            internal static extern int Cuncsd2by1(BLAS.LAYOUT matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, int m, int p, int q, System.IntPtr x11, int ldx11, System.IntPtr x21, int ldx21, float* theta, System.IntPtr u1, int ldu1, System.IntPtr u2, int ldu2, System.IntPtr v1t, int ldv1t);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cuncsd2by1_work")]
            internal static extern int Cuncsd2by1Work(BLAS.LAYOUT matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, int m, int p, int q, System.IntPtr x11, int ldx11, System.IntPtr x21, int ldx21, float* theta, System.IntPtr u1, int ldu1, System.IntPtr u2, int ldu2, System.IntPtr v1t, int ldv1t, System.IntPtr work, int lwork, float* rwork, int lrwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cuncsd_work")]
            internal static extern int CuncsdWork(BLAS.LAYOUT matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, sbyte jobv2t, BLAS.TRANS trans, sbyte signs, int m, int p, int q, System.IntPtr x11, int ldx11, System.IntPtr x12, int ldx12, System.IntPtr x21, int ldx21, System.IntPtr x22, int ldx22, float* theta, System.IntPtr u1, int ldu1, System.IntPtr u2, int ldu2, System.IntPtr v1t, int ldv1t, System.IntPtr v2t, int ldv2t, System.IntPtr work, int lwork, float* rwork, int lrwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cungbr")]
            internal static extern int Cungbr(BLAS.LAYOUT matrixLayout, sbyte vect, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cungbr_work")]
            internal static extern int CungbrWork(BLAS.LAYOUT matrixLayout, sbyte vect, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cunghr")]
            internal static extern int Cunghr(BLAS.LAYOUT matrixLayout, int n, int ilo, int ihi, System.IntPtr a, int lda, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cunghr_work")]
            internal static extern int CunghrWork(BLAS.LAYOUT matrixLayout, int n, int ilo, int ihi, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cunglq")]
            internal static extern int Cunglq(BLAS.LAYOUT matrixLayout, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cunglq_work")]
            internal static extern int CunglqWork(BLAS.LAYOUT matrixLayout, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cungql")]
            internal static extern int Cungql(BLAS.LAYOUT matrixLayout, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cungql_work")]
            internal static extern int CungqlWork(BLAS.LAYOUT matrixLayout, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cungqr")]
            internal static extern int Cungqr(BLAS.LAYOUT matrixLayout, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cungqr_work")]
            internal static extern int CungqrWork(BLAS.LAYOUT matrixLayout, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cungrq")]
            internal static extern int Cungrq(BLAS.LAYOUT matrixLayout, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cungrq_work")]
            internal static extern int CungrqWork(BLAS.LAYOUT matrixLayout, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cungtr")]
            internal static extern int Cungtr(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cungtr_work")]
            internal static extern int CungtrWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cunmbr")]
            internal static extern int Cunmbr(BLAS.LAYOUT matrixLayout, sbyte vect, sbyte side, BLAS.TRANS trans, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cunmbr_work")]
            internal static extern int CunmbrWork(BLAS.LAYOUT matrixLayout, sbyte vect, sbyte side, BLAS.TRANS trans, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr c, int ldc, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cunmhr")]
            internal static extern int Cunmhr(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int ilo, int ihi, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cunmhr_work")]
            internal static extern int CunmhrWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int ilo, int ihi, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr c, int ldc, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cunmlq")]
            internal static extern int Cunmlq(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cunmlq_work")]
            internal static extern int CunmlqWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr c, int ldc, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cunmql")]
            internal static extern int Cunmql(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cunmql_work")]
            internal static extern int CunmqlWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr c, int ldc, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cunmqr")]
            internal static extern int Cunmqr(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cunmqr_work")]
            internal static extern int CunmqrWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr c, int ldc, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cunmrq")]
            internal static extern int Cunmrq(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cunmrq_work")]
            internal static extern int CunmrqWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr c, int ldc, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cunmrz")]
            internal static extern int Cunmrz(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, int l, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cunmrz_work")]
            internal static extern int CunmrzWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, int l, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr c, int ldc, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cunmtr")]
            internal static extern int Cunmtr(BLAS.LAYOUT matrixLayout, sbyte side, sbyte uplo, BLAS.TRANS trans, int m, int n, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cunmtr_work")]
            internal static extern int CunmtrWork(BLAS.LAYOUT matrixLayout, sbyte side, sbyte uplo, BLAS.TRANS trans, int m, int n, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr c, int ldc, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cupgtr")]
            internal static extern int Cupgtr(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, System.IntPtr tau, System.IntPtr q, int ldq);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cupgtr_work")]
            internal static extern int CupgtrWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, System.IntPtr tau, System.IntPtr q, int ldq, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cupmtr")]
            internal static extern int Cupmtr(BLAS.LAYOUT matrixLayout, sbyte side, sbyte uplo, BLAS.TRANS trans, int m, int n, System.IntPtr ap, System.IntPtr tau, System.IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cupmtr_work")]
            internal static extern int CupmtrWork(BLAS.LAYOUT matrixLayout, sbyte side, sbyte uplo, BLAS.TRANS trans, int m, int n, System.IntPtr ap, System.IntPtr tau, System.IntPtr c, int ldc, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dbbcsd")]
            internal static extern int Dbbcsd(BLAS.LAYOUT matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, sbyte jobv2t, BLAS.TRANS trans, int m, int p, int q, double* theta, double* phi, double* u1, int ldu1, double* u2, int ldu2, double* v1t, int ldv1t, double* v2t, int ldv2t, double* b11d, double* b11e, double* b12d, double* b12e, double* b21d, double* b21e, double* b22d, double* b22e);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dbbcsd_work")]
            internal static extern int DbbcsdWork(BLAS.LAYOUT matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, sbyte jobv2t, BLAS.TRANS trans, int m, int p, int q, double* theta, double* phi, double* u1, int ldu1, double* u2, int ldu2, double* v1t, int ldv1t, double* v2t, int ldv2t, double* b11d, double* b11e, double* b12d, double* b12e, double* b21d, double* b21e, double* b22d, double* b22e, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dbdsdc")]
            internal static extern int Dbdsdc(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte compq, int n, double* d, double* e, double* u, int ldu, double* vt, int ldvt, double* q, int* iq);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dbdsdc_work")]
            internal static extern int DbdsdcWork(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte compq, int n, double* d, double* e, double* u, int ldu, double* vt, int ldvt, double* q, int* iq, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dbdsqr")]
            internal static extern int Dbdsqr(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int ncvt, int nru, int ncc, double* d, double* e, double* vt, int ldvt, double* u, int ldu, double* c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dbdsqr_work")]
            internal static extern int DbdsqrWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int ncvt, int nru, int ncc, double* d, double* e, double* vt, int ldvt, double* u, int ldu, double* c, int ldc, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dbdsvdx")]
            internal static extern int Dbdsvdx(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte jobz, sbyte range, int n, double* d, double* e, double vl, double vu, int il, int iu, int* ns, double* s, double* z, int ldz, int* superb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dbdsvdx_work")]
            internal static extern int DbdsvdxWork(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte jobz, sbyte range, int n, double* d, double* e, double vl, double vu, int il, int iu, int* ns, double* s, double* z, int ldz, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ddisna")]
            internal static extern int Ddisna(sbyte job, int m, int n, double* d, double* sep);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ddisna_work")]
            internal static extern int DdisnaWork(sbyte job, int m, int n, double* d, double* sep);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgbbrd")]
            internal static extern int Dgbbrd(BLAS.LAYOUT matrixLayout, sbyte vect, int m, int n, int ncc, int kl, int ku, double* ab, int ldab, double* d, double* e, double* q, int ldq, double* pt, int ldpt, double* c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgbbrd_work")]
            internal static extern int DgbbrdWork(BLAS.LAYOUT matrixLayout, sbyte vect, int m, int n, int ncc, int kl, int ku, double* ab, int ldab, double* d, double* e, double* q, int ldq, double* pt, int ldpt, double* c, int ldc, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgbcon")]
            internal static extern int Dgbcon(BLAS.LAYOUT matrixLayout, sbyte norm, int n, int kl, int ku, double* ab, int ldab, int* ipiv, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgbcon_work")]
            internal static extern int DgbconWork(BLAS.LAYOUT matrixLayout, sbyte norm, int n, int kl, int ku, double* ab, int ldab, int* ipiv, double anorm, double* rcond, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgbequ")]
            internal static extern int Dgbequ(BLAS.LAYOUT matrixLayout, int m, int n, int kl, int ku, double* ab, int ldab, double* r, double* c, double* rowcnd, double* colcnd, double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgbequ_work")]
            internal static extern int DgbequWork(BLAS.LAYOUT matrixLayout, int m, int n, int kl, int ku, double* ab, int ldab, double* r, double* c, double* rowcnd, double* colcnd, double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgbequb")]
            internal static extern int Dgbequb(BLAS.LAYOUT matrixLayout, int m, int n, int kl, int ku, double* ab, int ldab, double* r, double* c, double* rowcnd, double* colcnd, double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgbequb_work")]
            internal static extern int DgbequbWork(BLAS.LAYOUT matrixLayout, int m, int n, int kl, int ku, double* ab, int ldab, double* r, double* c, double* rowcnd, double* colcnd, double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgbrfs")]
            internal static extern int Dgbrfs(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, double* ab, int ldab, double* afb, int ldafb, int* ipiv, double* b, int ldb, double* x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgbrfs_work")]
            internal static extern int DgbrfsWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, double* ab, int ldab, double* afb, int ldafb, int* ipiv, double* b, int ldb, double* x, int ldx, double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgbrfsx")]
            internal static extern int Dgbrfsx(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, sbyte equed, int n, int kl, int ku, int nrhs, double* ab, int ldab, double* afb, int ldafb, int* ipiv, double* r, double* c, double* b, int ldb, double* x, int ldx, double* rcond, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgbrfsx_work")]
            internal static extern int DgbrfsxWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, sbyte equed, int n, int kl, int ku, int nrhs, double* ab, int ldab, double* afb, int ldafb, int* ipiv, double* r, double* c, double* b, int ldb, double* x, int ldx, double* rcond, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgbsv")]
            internal static extern int Dgbsv(BLAS.LAYOUT matrixLayout, int n, int kl, int ku, int nrhs, double* ab, int ldab, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgbsv_work")]
            internal static extern int DgbsvWork(BLAS.LAYOUT matrixLayout, int n, int kl, int ku, int nrhs, double* ab, int ldab, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgbsvx")]
            internal static extern int Dgbsvx(BLAS.LAYOUT matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, double* ab, int ldab, double* afb, int ldafb, int* ipiv, sbyte* equed, double* r, double* c, double* b, int ldb, double* x, int ldx, double* rcond, double* ferr, double* berr, double* rpivot);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgbsvx_work")]
            internal static extern int DgbsvxWork(BLAS.LAYOUT matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, double* ab, int ldab, double* afb, int ldafb, int* ipiv, sbyte* equed, double* r, double* c, double* b, int ldb, double* x, int ldx, double* rcond, double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgbsvxx")]
            internal static extern int Dgbsvxx(BLAS.LAYOUT matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, double* ab, int ldab, double* afb, int ldafb, int* ipiv, sbyte* equed, double* r, double* c, double* b, int ldb, double* x, int ldx, double* rcond, double* rpvgrw, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgbsvxx_work")]
            internal static extern int DgbsvxxWork(BLAS.LAYOUT matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, double* ab, int ldab, double* afb, int ldafb, int* ipiv, sbyte* equed, double* r, double* c, double* b, int ldb, double* x, int ldx, double* rcond, double* rpvgrw, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgbtrf")]
            internal static extern int Dgbtrf(BLAS.LAYOUT matrixLayout, int m, int n, int kl, int ku, double* ab, int ldab, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgbtrf_work")]
            internal static extern int DgbtrfWork(BLAS.LAYOUT matrixLayout, int m, int n, int kl, int ku, double* ab, int ldab, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgbtrs")]
            internal static extern int Dgbtrs(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, double* ab, int ldab, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgbtrs_work")]
            internal static extern int DgbtrsWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, double* ab, int ldab, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgebak")]
            internal static extern int Dgebak(BLAS.LAYOUT matrixLayout, sbyte job, sbyte side, int n, int ilo, int ihi, double* scale, int m, double* v, int ldv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgebak_work")]
            internal static extern int DgebakWork(BLAS.LAYOUT matrixLayout, sbyte job, sbyte side, int n, int ilo, int ihi, double* scale, int m, double* v, int ldv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgebal")]
            internal static extern int Dgebal(BLAS.LAYOUT matrixLayout, sbyte job, int n, double* a, int lda, int* ilo, int* ihi, double* scale);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgebal_work")]
            internal static extern int DgebalWork(BLAS.LAYOUT matrixLayout, sbyte job, int n, double* a, int lda, int* ilo, int* ihi, double* scale);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgebrd")]
            internal static extern int Dgebrd(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, double* d, double* e, double* tauq, double* taup);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgebrd_work")]
            internal static extern int DgebrdWork(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, double* d, double* e, double* tauq, double* taup, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgecon")]
            internal static extern int Dgecon(BLAS.LAYOUT matrixLayout, sbyte norm, int n, double* a, int lda, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgecon_work")]
            internal static extern int DgeconWork(BLAS.LAYOUT matrixLayout, sbyte norm, int n, double* a, int lda, double anorm, double* rcond, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgeequ")]
            internal static extern int Dgeequ(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, double* r, double* c, double* rowcnd, double* colcnd, double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgeequ_work")]
            internal static extern int DgeequWork(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, double* r, double* c, double* rowcnd, double* colcnd, double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgeequb")]
            internal static extern int Dgeequb(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, double* r, double* c, double* rowcnd, double* colcnd, double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgeequb_work")]
            internal static extern int DgeequbWork(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, double* r, double* c, double* rowcnd, double* colcnd, double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgees")]
            internal static extern int Dgees(BLAS.LAYOUT matrixLayout, sbyte jobvs, sbyte sort, System.IntPtr select, int n, double* a, int lda, int* sdim, double* wr, double* wi, double* vs, int ldvs);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgees_work")]
            internal static extern int DgeesWork(BLAS.LAYOUT matrixLayout, sbyte jobvs, sbyte sort, System.IntPtr select, int n, double* a, int lda, int* sdim, double* wr, double* wi, double* vs, int ldvs, double* work, int lwork, int* bwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgeesx")]
            internal static extern int Dgeesx(BLAS.LAYOUT matrixLayout, sbyte jobvs, sbyte sort, System.IntPtr select, sbyte sense, int n, double* a, int lda, int* sdim, double* wr, double* wi, double* vs, int ldvs, double* rconde, double* rcondv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgeesx_work")]
            internal static extern int DgeesxWork(BLAS.LAYOUT matrixLayout, sbyte jobvs, sbyte sort, System.IntPtr select, sbyte sense, int n, double* a, int lda, int* sdim, double* wr, double* wi, double* vs, int ldvs, double* rconde, double* rcondv, double* work, int lwork, int* iwork, int liwork, int* bwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgeev")]
            internal static extern int Dgeev(BLAS.LAYOUT matrixLayout, sbyte jobvl, sbyte jobvr, int n, double* a, int lda, double* wr, double* wi, double* vl, int ldvl, double* vr, int ldvr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgeev_work")]
            internal static extern int DgeevWork(BLAS.LAYOUT matrixLayout, sbyte jobvl, sbyte jobvr, int n, double* a, int lda, double* wr, double* wi, double* vl, int ldvl, double* vr, int ldvr, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgeevx")]
            internal static extern int Dgeevx(BLAS.LAYOUT matrixLayout, sbyte balanc, sbyte jobvl, sbyte jobvr, sbyte sense, int n, double* a, int lda, double* wr, double* wi, double* vl, int ldvl, double* vr, int ldvr, int* ilo, int* ihi, double* scale, double* abnrm, double* rconde, double* rcondv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgeevx_work")]
            internal static extern int DgeevxWork(BLAS.LAYOUT matrixLayout, sbyte balanc, sbyte jobvl, sbyte jobvr, sbyte sense, int n, double* a, int lda, double* wr, double* wi, double* vl, int ldvl, double* vr, int ldvr, int* ilo, int* ihi, double* scale, double* abnrm, double* rconde, double* rcondv, double* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgehrd")]
            internal static extern int Dgehrd(BLAS.LAYOUT matrixLayout, int n, int ilo, int ihi, double* a, int lda, double* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgehrd_work")]
            internal static extern int DgehrdWork(BLAS.LAYOUT matrixLayout, int n, int ilo, int ihi, double* a, int lda, double* tau, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgejsv")]
            internal static extern int Dgejsv(BLAS.LAYOUT matrixLayout, sbyte joba, sbyte jobu, sbyte jobv, sbyte jobr, sbyte jobt, sbyte jobp, int m, int n, double* a, int lda, double* sva, double* u, int ldu, double* v, int ldv, double* stat, int* istat);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgejsv_work")]
            internal static extern int DgejsvWork(BLAS.LAYOUT matrixLayout, sbyte joba, sbyte jobu, sbyte jobv, sbyte jobr, sbyte jobt, sbyte jobp, int m, int n, double* a, int lda, double* sva, double* u, int ldu, double* v, int ldv, double* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgelq2")]
            internal static extern int Dgelq2(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, double* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgelq2_work")]
            internal static extern int Dgelq2Work(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, double* tau, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgelqf")]
            internal static extern int Dgelqf(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, double* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgelqf_work")]
            internal static extern int DgelqfWork(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, double* tau, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgels")]
            internal static extern int Dgels(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int m, int n, int nrhs, double* a, int lda, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgels_work")]
            internal static extern int DgelsWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int m, int n, int nrhs, double* a, int lda, double* b, int ldb, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgelsd")]
            internal static extern int Dgelsd(BLAS.LAYOUT matrixLayout, int m, int n, int nrhs, double* a, int lda, double* b, int ldb, double* s, double rcond, int* rank);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgelsd_work")]
            internal static extern int DgelsdWork(BLAS.LAYOUT matrixLayout, int m, int n, int nrhs, double* a, int lda, double* b, int ldb, double* s, double rcond, int* rank, double* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgelss")]
            internal static extern int Dgelss(BLAS.LAYOUT matrixLayout, int m, int n, int nrhs, double* a, int lda, double* b, int ldb, double* s, double rcond, int* rank);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgelss_work")]
            internal static extern int DgelssWork(BLAS.LAYOUT matrixLayout, int m, int n, int nrhs, double* a, int lda, double* b, int ldb, double* s, double rcond, int* rank, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgelsy")]
            internal static extern int Dgelsy(BLAS.LAYOUT matrixLayout, int m, int n, int nrhs, double* a, int lda, double* b, int ldb, int* jpvt, double rcond, int* rank);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgelsy_work")]
            internal static extern int DgelsyWork(BLAS.LAYOUT matrixLayout, int m, int n, int nrhs, double* a, int lda, double* b, int ldb, int* jpvt, double rcond, int* rank, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgemqrt")]
            internal static extern int Dgemqrt(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, int nb, double* v, int ldv, double* t, int ldt, double* c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgemqrt_work")]
            internal static extern int DgemqrtWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, int nb, double* v, int ldv, double* t, int ldt, double* c, int ldc, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgeqlf")]
            internal static extern int Dgeqlf(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, double* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgeqlf_work")]
            internal static extern int DgeqlfWork(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, double* tau, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgeqp3")]
            internal static extern int Dgeqp3(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, int* jpvt, double* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgeqp3_work")]
            internal static extern int Dgeqp3Work(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, int* jpvt, double* tau, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgeqpf")]
            internal static extern int Dgeqpf(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, int* jpvt, double* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgeqpf_work")]
            internal static extern int DgeqpfWork(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, int* jpvt, double* tau, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgeqr2")]
            internal static extern int Dgeqr2(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, double* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgeqr2_work")]
            internal static extern int Dgeqr2Work(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, double* tau, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgeqrf")]
            internal static extern int Dgeqrf(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, double* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgeqrf_work")]
            internal static extern int DgeqrfWork(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, double* tau, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgeqrfp")]
            internal static extern int Dgeqrfp(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, double* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgeqrfp_work")]
            internal static extern int DgeqrfpWork(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, double* tau, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgeqrt")]
            internal static extern int Dgeqrt(BLAS.LAYOUT matrixLayout, int m, int n, int nb, double* a, int lda, double* t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgeqrt2")]
            internal static extern int Dgeqrt2(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, double* t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgeqrt2_work")]
            internal static extern int Dgeqrt2Work(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, double* t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgeqrt3")]
            internal static extern int Dgeqrt3(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, double* t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgeqrt3_work")]
            internal static extern int Dgeqrt3Work(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, double* t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgeqrt_work")]
            internal static extern int DgeqrtWork(BLAS.LAYOUT matrixLayout, int m, int n, int nb, double* a, int lda, double* t, int ldt, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgerfs")]
            internal static extern int Dgerfs(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int nrhs, double* a, int lda, double* af, int ldaf, int* ipiv, double* b, int ldb, double* x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgerfs_work")]
            internal static extern int DgerfsWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int nrhs, double* a, int lda, double* af, int ldaf, int* ipiv, double* b, int ldb, double* x, int ldx, double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgerfsx")]
            internal static extern int Dgerfsx(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, sbyte equed, int n, int nrhs, double* a, int lda, double* af, int ldaf, int* ipiv, double* r, double* c, double* b, int ldb, double* x, int ldx, double* rcond, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgerfsx_work")]
            internal static extern int DgerfsxWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, sbyte equed, int n, int nrhs, double* a, int lda, double* af, int ldaf, int* ipiv, double* r, double* c, double* b, int ldb, double* x, int ldx, double* rcond, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgerqf")]
            internal static extern int Dgerqf(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, double* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgerqf_work")]
            internal static extern int DgerqfWork(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, double* tau, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgesdd")]
            internal static extern int Dgesdd(BLAS.LAYOUT matrixLayout, sbyte jobz, int m, int n, double* a, int lda, double* s, double* u, int ldu, double* vt, int ldvt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgesdd_work")]
            internal static extern int DgesddWork(BLAS.LAYOUT matrixLayout, sbyte jobz, int m, int n, double* a, int lda, double* s, double* u, int ldu, double* vt, int ldvt, double* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgesv")]
            internal static extern int Dgesv(BLAS.LAYOUT matrixLayout, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgesv_work")]
            internal static extern int DgesvWork(BLAS.LAYOUT matrixLayout, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgesvd")]
            internal static extern int Dgesvd(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobvt, int m, int n, double* a, int lda, double* s, double* u, int ldu, double* vt, int ldvt, double* superb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgesvd_work")]
            internal static extern int DgesvdWork(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobvt, int m, int n, double* a, int lda, double* s, double* u, int ldu, double* vt, int ldvt, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgesvdx")]
            internal static extern int Dgesvdx(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobvt, sbyte range, int m, int n, double* a, int lda, double vl, double vu, int il, int iu, int* ns, double* s, double* u, int ldu, double* vt, int ldvt, int* superb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgesvdx_work")]
            internal static extern int DgesvdxWork(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobvt, sbyte range, int m, int n, double* a, int lda, double vl, double vu, int il, int iu, int* ns, double* s, double* u, int ldu, double* vt, int ldvt, double* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgesvj")]
            internal static extern int Dgesvj(BLAS.LAYOUT matrixLayout, sbyte joba, sbyte jobu, sbyte jobv, int m, int n, double* a, int lda, double* sva, int mv, double* v, int ldv, double* stat);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgesvj_work")]
            internal static extern int DgesvjWork(BLAS.LAYOUT matrixLayout, sbyte joba, sbyte jobu, sbyte jobv, int m, int n, double* a, int lda, double* sva, int mv, double* v, int ldv, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgesvx")]
            internal static extern int Dgesvx(BLAS.LAYOUT matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int nrhs, double* a, int lda, double* af, int ldaf, int* ipiv, sbyte* equed, double* r, double* c, double* b, int ldb, double* x, int ldx, double* rcond, double* ferr, double* berr, double* rpivot);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgesvx_work")]
            internal static extern int DgesvxWork(BLAS.LAYOUT matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int nrhs, double* a, int lda, double* af, int ldaf, int* ipiv, sbyte* equed, double* r, double* c, double* b, int ldb, double* x, int ldx, double* rcond, double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgesvxx")]
            internal static extern int Dgesvxx(BLAS.LAYOUT matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int nrhs, double* a, int lda, double* af, int ldaf, int* ipiv, sbyte* equed, double* r, double* c, double* b, int ldb, double* x, int ldx, double* rcond, double* rpvgrw, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgesvxx_work")]
            internal static extern int DgesvxxWork(BLAS.LAYOUT matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int nrhs, double* a, int lda, double* af, int ldaf, int* ipiv, sbyte* equed, double* r, double* c, double* b, int ldb, double* x, int ldx, double* rcond, double* rpvgrw, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgetf2")]
            internal static extern int Dgetf2(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgetf2_work")]
            internal static extern int Dgetf2Work(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgetrf")]
            internal static extern int Dgetrf(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgetrf2")]
            internal static extern int Dgetrf2(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgetrf2_work")]
            internal static extern int Dgetrf2Work(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgetrf_work")]
            internal static extern int DgetrfWork(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgetri")]
            internal static extern int Dgetri(BLAS.LAYOUT matrixLayout, int n, double* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgetri_work")]
            internal static extern int DgetriWork(BLAS.LAYOUT matrixLayout, int n, double* a, int lda, int* ipiv, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgetrs")]
            internal static extern int Dgetrs(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgetrs_work")]
            internal static extern int DgetrsWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dggbak")]
            internal static extern int Dggbak(BLAS.LAYOUT matrixLayout, sbyte job, sbyte side, int n, int ilo, int ihi, double* lscale, double* rscale, int m, double* v, int ldv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dggbak_work")]
            internal static extern int DggbakWork(BLAS.LAYOUT matrixLayout, sbyte job, sbyte side, int n, int ilo, int ihi, double* lscale, double* rscale, int m, double* v, int ldv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dggbal")]
            internal static extern int Dggbal(BLAS.LAYOUT matrixLayout, sbyte job, int n, double* a, int lda, double* b, int ldb, int* ilo, int* ihi, double* lscale, double* rscale);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dggbal_work")]
            internal static extern int DggbalWork(BLAS.LAYOUT matrixLayout, sbyte job, int n, double* a, int lda, double* b, int ldb, int* ilo, int* ihi, double* lscale, double* rscale, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgges")]
            internal static extern int Dgges(BLAS.LAYOUT matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, System.IntPtr selctg, int n, double* a, int lda, double* b, int ldb, int* sdim, double* alphar, double* alphai, double* beta, double* vsl, int ldvsl, double* vsr, int ldvsr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgges3")]
            internal static extern int Dgges3(BLAS.LAYOUT matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, System.IntPtr selctg, int n, double* a, int lda, double* b, int ldb, int* sdim, double* alphar, double* alphai, double* beta, double* vsl, int ldvsl, double* vsr, int ldvsr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgges3_work")]
            internal static extern int Dgges3Work(BLAS.LAYOUT matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, System.IntPtr selctg, int n, double* a, int lda, double* b, int ldb, int* sdim, double* alphar, double* alphai, double* beta, double* vsl, int ldvsl, double* vsr, int ldvsr, double* work, int lwork, int* bwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgges_work")]
            internal static extern int DggesWork(BLAS.LAYOUT matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, System.IntPtr selctg, int n, double* a, int lda, double* b, int ldb, int* sdim, double* alphar, double* alphai, double* beta, double* vsl, int ldvsl, double* vsr, int ldvsr, double* work, int lwork, int* bwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dggesx")]
            internal static extern int Dggesx(BLAS.LAYOUT matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, System.IntPtr selctg, sbyte sense, int n, double* a, int lda, double* b, int ldb, int* sdim, double* alphar, double* alphai, double* beta, double* vsl, int ldvsl, double* vsr, int ldvsr, double* rconde, double* rcondv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dggesx_work")]
            internal static extern int DggesxWork(BLAS.LAYOUT matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, System.IntPtr selctg, sbyte sense, int n, double* a, int lda, double* b, int ldb, int* sdim, double* alphar, double* alphai, double* beta, double* vsl, int ldvsl, double* vsr, int ldvsr, double* rconde, double* rcondv, double* work, int lwork, int* iwork, int liwork, int* bwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dggev")]
            internal static extern int Dggev(BLAS.LAYOUT matrixLayout, sbyte jobvl, sbyte jobvr, int n, double* a, int lda, double* b, int ldb, double* alphar, double* alphai, double* beta, double* vl, int ldvl, double* vr, int ldvr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dggev3")]
            internal static extern int Dggev3(BLAS.LAYOUT matrixLayout, sbyte jobvl, sbyte jobvr, int n, double* a, int lda, double* b, int ldb, double* alphar, double* alphai, double* beta, double* vl, int ldvl, double* vr, int ldvr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dggev3_work")]
            internal static extern int Dggev3Work(BLAS.LAYOUT matrixLayout, sbyte jobvl, sbyte jobvr, int n, double* a, int lda, double* b, int ldb, double* alphar, double* alphai, double* beta, double* vl, int ldvl, double* vr, int ldvr, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dggev_work")]
            internal static extern int DggevWork(BLAS.LAYOUT matrixLayout, sbyte jobvl, sbyte jobvr, int n, double* a, int lda, double* b, int ldb, double* alphar, double* alphai, double* beta, double* vl, int ldvl, double* vr, int ldvr, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dggevx")]
            internal static extern int Dggevx(BLAS.LAYOUT matrixLayout, sbyte balanc, sbyte jobvl, sbyte jobvr, sbyte sense, int n, double* a, int lda, double* b, int ldb, double* alphar, double* alphai, double* beta, double* vl, int ldvl, double* vr, int ldvr, int* ilo, int* ihi, double* lscale, double* rscale, double* abnrm, double* bbnrm, double* rconde, double* rcondv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dggevx_work")]
            internal static extern int DggevxWork(BLAS.LAYOUT matrixLayout, sbyte balanc, sbyte jobvl, sbyte jobvr, sbyte sense, int n, double* a, int lda, double* b, int ldb, double* alphar, double* alphai, double* beta, double* vl, int ldvl, double* vr, int ldvr, int* ilo, int* ihi, double* lscale, double* rscale, double* abnrm, double* bbnrm, double* rconde, double* rcondv, double* work, int lwork, int* iwork, int* bwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dggglm")]
            internal static extern int Dggglm(BLAS.LAYOUT matrixLayout, int n, int m, int p, double* a, int lda, double* b, int ldb, double* d, double* x, double* y);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dggglm_work")]
            internal static extern int DggglmWork(BLAS.LAYOUT matrixLayout, int n, int m, int p, double* a, int lda, double* b, int ldb, double* d, double* x, double* y, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgghd3")]
            internal static extern int Dgghd3(BLAS.LAYOUT matrixLayout, sbyte compq, sbyte compz, int n, int ilo, int ihi, double* a, int lda, double* b, int ldb, double* q, int ldq, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgghd3_work")]
            internal static extern int Dgghd3Work(BLAS.LAYOUT matrixLayout, sbyte compq, sbyte compz, int n, int ilo, int ihi, double* a, int lda, double* b, int ldb, double* q, int ldq, double* z, int ldz, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgghrd")]
            internal static extern int Dgghrd(BLAS.LAYOUT matrixLayout, sbyte compq, sbyte compz, int n, int ilo, int ihi, double* a, int lda, double* b, int ldb, double* q, int ldq, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgghrd_work")]
            internal static extern int DgghrdWork(BLAS.LAYOUT matrixLayout, sbyte compq, sbyte compz, int n, int ilo, int ihi, double* a, int lda, double* b, int ldb, double* q, int ldq, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgglse")]
            internal static extern int Dgglse(BLAS.LAYOUT matrixLayout, int m, int n, int p, double* a, int lda, double* b, int ldb, double* c, double* d, double* x);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgglse_work")]
            internal static extern int DgglseWork(BLAS.LAYOUT matrixLayout, int m, int n, int p, double* a, int lda, double* b, int ldb, double* c, double* d, double* x, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dggqrf")]
            internal static extern int Dggqrf(BLAS.LAYOUT matrixLayout, int n, int m, int p, double* a, int lda, double* taua, double* b, int ldb, double* taub);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dggqrf_work")]
            internal static extern int DggqrfWork(BLAS.LAYOUT matrixLayout, int n, int m, int p, double* a, int lda, double* taua, double* b, int ldb, double* taub, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dggrqf")]
            internal static extern int Dggrqf(BLAS.LAYOUT matrixLayout, int m, int p, int n, double* a, int lda, double* taua, double* b, int ldb, double* taub);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dggrqf_work")]
            internal static extern int DggrqfWork(BLAS.LAYOUT matrixLayout, int m, int p, int n, double* a, int lda, double* taua, double* b, int ldb, double* taub, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dggsvd")]
            internal static extern int Dggsvd(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int n, int p, int* k, int* l, double* a, int lda, double* b, int ldb, double* alpha, double* beta, double* u, int ldu, double* v, int ldv, double* q, int ldq, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dggsvd3")]
            internal static extern int Dggsvd3(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int n, int p, int* k, int* l, double* a, int lda, double* b, int ldb, double* alpha, double* beta, double* u, int ldu, double* v, int ldv, double* q, int ldq, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dggsvd3_work")]
            internal static extern int Dggsvd3Work(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int n, int p, int* k, int* l, double* a, int lda, double* b, int ldb, double* alpha, double* beta, double* u, int ldu, double* v, int ldv, double* q, int ldq, double* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dggsvd_work")]
            internal static extern int DggsvdWork(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int n, int p, int* k, int* l, double* a, int lda, double* b, int ldb, double* alpha, double* beta, double* u, int ldu, double* v, int ldv, double* q, int ldq, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dggsvp")]
            internal static extern int Dggsvp(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, double* a, int lda, double* b, int ldb, double tola, double tolb, int* k, int* l, double* u, int ldu, double* v, int ldv, double* q, int ldq);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dggsvp3")]
            internal static extern int Dggsvp3(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, double* a, int lda, double* b, int ldb, double tola, double tolb, int* k, int* l, double* u, int ldu, double* v, int ldv, double* q, int ldq);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dggsvp3_work")]
            internal static extern int Dggsvp3Work(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, double* a, int lda, double* b, int ldb, double tola, double tolb, int* k, int* l, double* u, int ldu, double* v, int ldv, double* q, int ldq, int* iwork, double* tau, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dggsvp_work")]
            internal static extern int DggsvpWork(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, double* a, int lda, double* b, int ldb, double tola, double tolb, int* k, int* l, double* u, int ldu, double* v, int ldv, double* q, int ldq, int* iwork, double* tau, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgtcon")]
            internal static extern int Dgtcon(sbyte norm, int n, double* dl, double* d, double* du, double* du2, int* ipiv, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgtcon_work")]
            internal static extern int DgtconWork(sbyte norm, int n, double* dl, double* d, double* du, double* du2, int* ipiv, double anorm, double* rcond, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgtrfs")]
            internal static extern int Dgtrfs(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int nrhs, double* dl, double* d, double* du, double* dlf, double* df, double* duf, double* du2, int* ipiv, double* b, int ldb, double* x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgtrfs_work")]
            internal static extern int DgtrfsWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int nrhs, double* dl, double* d, double* du, double* dlf, double* df, double* duf, double* du2, int* ipiv, double* b, int ldb, double* x, int ldx, double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgtsv")]
            internal static extern int Dgtsv(BLAS.LAYOUT matrixLayout, int n, int nrhs, double* dl, double* d, double* du, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgtsv_work")]
            internal static extern int DgtsvWork(BLAS.LAYOUT matrixLayout, int n, int nrhs, double* dl, double* d, double* du, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgtsvx")]
            internal static extern int Dgtsvx(BLAS.LAYOUT matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int nrhs, double* dl, double* d, double* du, double* dlf, double* df, double* duf, double* du2, int* ipiv, double* b, int ldb, double* x, int ldx, double* rcond, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgtsvx_work")]
            internal static extern int DgtsvxWork(BLAS.LAYOUT matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int nrhs, double* dl, double* d, double* du, double* dlf, double* df, double* duf, double* du2, int* ipiv, double* b, int ldb, double* x, int ldx, double* rcond, double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgttrf")]
            internal static extern int Dgttrf(int n, double* dl, double* d, double* du, double* du2, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgttrf_work")]
            internal static extern int DgttrfWork(int n, double* dl, double* d, double* du, double* du2, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgttrs")]
            internal static extern int Dgttrs(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int nrhs, double* dl, double* d, double* du, double* du2, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgttrs_work")]
            internal static extern int DgttrsWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int nrhs, double* dl, double* d, double* du, double* du2, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dhgeqz")]
            internal static extern int Dhgeqz(BLAS.LAYOUT matrixLayout, sbyte job, sbyte compq, sbyte compz, int n, int ilo, int ihi, double* h, int ldh, double* t, int ldt, double* alphar, double* alphai, double* beta, double* q, int ldq, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dhgeqz_work")]
            internal static extern int DhgeqzWork(BLAS.LAYOUT matrixLayout, sbyte job, sbyte compq, sbyte compz, int n, int ilo, int ihi, double* h, int ldh, double* t, int ldt, double* alphar, double* alphai, double* beta, double* q, int ldq, double* z, int ldz, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dhsein")]
            internal static extern int Dhsein(BLAS.LAYOUT matrixLayout, sbyte job, sbyte eigsrc, sbyte initv, int* select, int n, double* h, int ldh, double* wr, double* wi, double* vl, int ldvl, double* vr, int ldvr, int mm, int* m, int* ifaill, int* ifailr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dhsein_work")]
            internal static extern int DhseinWork(BLAS.LAYOUT matrixLayout, sbyte job, sbyte eigsrc, sbyte initv, int* select, int n, double* h, int ldh, double* wr, double* wi, double* vl, int ldvl, double* vr, int ldvr, int mm, int* m, double* work, int* ifaill, int* ifailr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dhseqr")]
            internal static extern int Dhseqr(BLAS.LAYOUT matrixLayout, sbyte job, sbyte compz, int n, int ilo, int ihi, double* h, int ldh, double* wr, double* wi, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dhseqr_work")]
            internal static extern int DhseqrWork(BLAS.LAYOUT matrixLayout, sbyte job, sbyte compz, int n, int ilo, int ihi, double* h, int ldh, double* wr, double* wi, double* z, int ldz, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dlacn2")]
            internal static extern int Dlacn2(int n, double* v, double* x, int* isgn, double* est, int* kase, int* isave);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dlacn2_work")]
            internal static extern int Dlacn2Work(int n, double* v, double* x, int* isgn, double* est, int* kase, int* isave);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dlacpy")]
            internal static extern int Dlacpy(BLAS.LAYOUT matrixLayout, sbyte uplo, int m, int n, double* a, int lda, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dlacpy_work")]
            internal static extern int DlacpyWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int m, int n, double* a, int lda, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dlag2s")]
            internal static extern int Dlag2s(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, float* sa, int ldsa);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dlag2s_work")]
            internal static extern int Dlag2sWork(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, float* sa, int ldsa);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dlagge")]
            internal static extern int Dlagge(BLAS.LAYOUT matrixLayout, int m, int n, int kl, int ku, double* d, double* a, int lda, int* iseed);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dlagge_work")]
            internal static extern int DlaggeWork(BLAS.LAYOUT matrixLayout, int m, int n, int kl, int ku, double* d, double* a, int lda, int* iseed, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dlagsy")]
            internal static extern int Dlagsy(BLAS.LAYOUT matrixLayout, int n, int k, double* d, double* a, int lda, int* iseed);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dlagsy_work")]
            internal static extern int DlagsyWork(BLAS.LAYOUT matrixLayout, int n, int k, double* d, double* a, int lda, int* iseed, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dlapmr")]
            internal static extern int Dlapmr(BLAS.LAYOUT matrixLayout, int forwrd, int m, int n, double* x, int ldx, int* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dlapmr_work")]
            internal static extern int DlapmrWork(BLAS.LAYOUT matrixLayout, int forwrd, int m, int n, double* x, int ldx, int* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dlapmt")]
            internal static extern int Dlapmt(BLAS.LAYOUT matrixLayout, int forwrd, int m, int n, double* x, int ldx, int* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dlapmt_work")]
            internal static extern int DlapmtWork(BLAS.LAYOUT matrixLayout, int forwrd, int m, int n, double* x, int ldx, int* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dlarfb")]
            internal static extern int Dlarfb(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, sbyte direct, sbyte storev, int m, int n, int k, double* v, int ldv, double* t, int ldt, double* c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dlarfb_work")]
            internal static extern int DlarfbWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, sbyte direct, sbyte storev, int m, int n, int k, double* v, int ldv, double* t, int ldt, double* c, int ldc, double* work, int ldwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dlarfg")]
            internal static extern int Dlarfg(int n, double* alpha, double* x, int incx, double* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dlarfg_work")]
            internal static extern int DlarfgWork(int n, double* alpha, double* x, int incx, double* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dlarft")]
            internal static extern int Dlarft(BLAS.LAYOUT matrixLayout, sbyte direct, sbyte storev, int n, int k, double* v, int ldv, double* tau, double* t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dlarft_work")]
            internal static extern int DlarftWork(BLAS.LAYOUT matrixLayout, sbyte direct, sbyte storev, int n, int k, double* v, int ldv, double* tau, double* t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dlarfx")]
            internal static extern int Dlarfx(BLAS.LAYOUT matrixLayout, sbyte side, int m, int n, double* v, double tau, double* c, int ldc, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dlarfx_work")]
            internal static extern int DlarfxWork(BLAS.LAYOUT matrixLayout, sbyte side, int m, int n, double* v, double tau, double* c, int ldc, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dlarnv")]
            internal static extern int Dlarnv(int idist, int* iseed, int n, double* x);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dlarnv_work")]
            internal static extern int DlarnvWork(int idist, int* iseed, int n, double* x);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dlartgp")]
            internal static extern int Dlartgp(double f, double g, double* cs, double* sn, double* r);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dlartgp_work")]
            internal static extern int DlartgpWork(double f, double g, double* cs, double* sn, double* r);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dlartgs")]
            internal static extern int Dlartgs(double x, double y, double sigma, double* cs, double* sn);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dlartgs_work")]
            internal static extern int DlartgsWork(double x, double y, double sigma, double* cs, double* sn);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dlascl")]
            internal static extern int Dlascl(BLAS.LAYOUT matrixLayout, sbyte type, int kl, int ku, double cfrom, double cto, int m, int n, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dlascl_work")]
            internal static extern int DlasclWork(BLAS.LAYOUT matrixLayout, sbyte type, int kl, int ku, double cfrom, double cto, int m, int n, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dlaset")]
            internal static extern int Dlaset(BLAS.LAYOUT matrixLayout, sbyte uplo, int m, int n, double alpha, double beta, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dlaset_work")]
            internal static extern int DlasetWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int m, int n, double alpha, double beta, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dlasrt")]
            internal static extern int Dlasrt(sbyte id, int n, double* d);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dlasrt_work")]
            internal static extern int DlasrtWork(sbyte id, int n, double* d);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dlaswp")]
            internal static extern int Dlaswp(BLAS.LAYOUT matrixLayout, int n, double* a, int lda, int k1, int k2, int* ipiv, int incx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dlaswp_work")]
            internal static extern int DlaswpWork(BLAS.LAYOUT matrixLayout, int n, double* a, int lda, int k1, int k2, int* ipiv, int incx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dlatms")]
            internal static extern int Dlatms(BLAS.LAYOUT matrixLayout, int m, int n, sbyte dist, int* iseed, sbyte sym, double* d, int mode, double cond, double dmax, int kl, int ku, sbyte pack, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dlatms_work")]
            internal static extern int DlatmsWork(BLAS.LAYOUT matrixLayout, int m, int n, sbyte dist, int* iseed, sbyte sym, double* d, int mode, double cond, double dmax, int kl, int ku, sbyte pack, double* a, int lda, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dlauum")]
            internal static extern int Dlauum(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dlauum_work")]
            internal static extern int DlauumWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dopgtr")]
            internal static extern int Dopgtr(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* ap, double* tau, double* q, int ldq);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dopgtr_work")]
            internal static extern int DopgtrWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* ap, double* tau, double* q, int ldq, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dopmtr")]
            internal static extern int Dopmtr(BLAS.LAYOUT matrixLayout, sbyte side, sbyte uplo, BLAS.TRANS trans, int m, int n, double* ap, double* tau, double* c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dopmtr_work")]
            internal static extern int DopmtrWork(BLAS.LAYOUT matrixLayout, sbyte side, sbyte uplo, BLAS.TRANS trans, int m, int n, double* ap, double* tau, double* c, int ldc, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dorbdb")]
            internal static extern int Dorbdb(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, sbyte signs, int m, int p, int q, double* x11, int ldx11, double* x12, int ldx12, double* x21, int ldx21, double* x22, int ldx22, double* theta, double* phi, double* taup1, double* taup2, double* tauq1, double* tauq2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dorbdb_work")]
            internal static extern int DorbdbWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, sbyte signs, int m, int p, int q, double* x11, int ldx11, double* x12, int ldx12, double* x21, int ldx21, double* x22, int ldx22, double* theta, double* phi, double* taup1, double* taup2, double* tauq1, double* tauq2, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dorcsd")]
            internal static extern int Dorcsd(BLAS.LAYOUT matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, sbyte jobv2t, BLAS.TRANS trans, sbyte signs, int m, int p, int q, double* x11, int ldx11, double* x12, int ldx12, double* x21, int ldx21, double* x22, int ldx22, double* theta, double* u1, int ldu1, double* u2, int ldu2, double* v1t, int ldv1t, double* v2t, int ldv2t);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dorcsd2by1")]
            internal static extern int Dorcsd2by1(BLAS.LAYOUT matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, int m, int p, int q, double* x11, int ldx11, double* x21, int ldx21, double* theta, double* u1, int ldu1, double* u2, int ldu2, double* v1t, int ldv1t);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dorcsd2by1_work")]
            internal static extern int Dorcsd2by1Work(BLAS.LAYOUT matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, int m, int p, int q, double* x11, int ldx11, double* x21, int ldx21, double* theta, double* u1, int ldu1, double* u2, int ldu2, double* v1t, int ldv1t, double* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dorcsd_work")]
            internal static extern int DorcsdWork(BLAS.LAYOUT matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, sbyte jobv2t, BLAS.TRANS trans, sbyte signs, int m, int p, int q, double* x11, int ldx11, double* x12, int ldx12, double* x21, int ldx21, double* x22, int ldx22, double* theta, double* u1, int ldu1, double* u2, int ldu2, double* v1t, int ldv1t, double* v2t, int ldv2t, double* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dorgbr")]
            internal static extern int Dorgbr(BLAS.LAYOUT matrixLayout, sbyte vect, int m, int n, int k, double* a, int lda, double* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dorgbr_work")]
            internal static extern int DorgbrWork(BLAS.LAYOUT matrixLayout, sbyte vect, int m, int n, int k, double* a, int lda, double* tau, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dorghr")]
            internal static extern int Dorghr(BLAS.LAYOUT matrixLayout, int n, int ilo, int ihi, double* a, int lda, double* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dorghr_work")]
            internal static extern int DorghrWork(BLAS.LAYOUT matrixLayout, int n, int ilo, int ihi, double* a, int lda, double* tau, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dorglq")]
            internal static extern int Dorglq(BLAS.LAYOUT matrixLayout, int m, int n, int k, double* a, int lda, double* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dorglq_work")]
            internal static extern int DorglqWork(BLAS.LAYOUT matrixLayout, int m, int n, int k, double* a, int lda, double* tau, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dorgql")]
            internal static extern int Dorgql(BLAS.LAYOUT matrixLayout, int m, int n, int k, double* a, int lda, double* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dorgql_work")]
            internal static extern int DorgqlWork(BLAS.LAYOUT matrixLayout, int m, int n, int k, double* a, int lda, double* tau, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dorgqr")]
            internal static extern int Dorgqr(BLAS.LAYOUT matrixLayout, int m, int n, int k, double* a, int lda, double* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dorgqr_work")]
            internal static extern int DorgqrWork(BLAS.LAYOUT matrixLayout, int m, int n, int k, double* a, int lda, double* tau, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dorgrq")]
            internal static extern int Dorgrq(BLAS.LAYOUT matrixLayout, int m, int n, int k, double* a, int lda, double* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dorgrq_work")]
            internal static extern int DorgrqWork(BLAS.LAYOUT matrixLayout, int m, int n, int k, double* a, int lda, double* tau, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dorgtr")]
            internal static extern int Dorgtr(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda, double* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dorgtr_work")]
            internal static extern int DorgtrWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda, double* tau, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dormbr")]
            internal static extern int Dormbr(BLAS.LAYOUT matrixLayout, sbyte vect, sbyte side, BLAS.TRANS trans, int m, int n, int k, double* a, int lda, double* tau, double* c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dormbr_work")]
            internal static extern int DormbrWork(BLAS.LAYOUT matrixLayout, sbyte vect, sbyte side, BLAS.TRANS trans, int m, int n, int k, double* a, int lda, double* tau, double* c, int ldc, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dormhr")]
            internal static extern int Dormhr(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int ilo, int ihi, double* a, int lda, double* tau, double* c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dormhr_work")]
            internal static extern int DormhrWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int ilo, int ihi, double* a, int lda, double* tau, double* c, int ldc, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dormlq")]
            internal static extern int Dormlq(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, double* a, int lda, double* tau, double* c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dormlq_work")]
            internal static extern int DormlqWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, double* a, int lda, double* tau, double* c, int ldc, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dormql")]
            internal static extern int Dormql(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, double* a, int lda, double* tau, double* c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dormql_work")]
            internal static extern int DormqlWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, double* a, int lda, double* tau, double* c, int ldc, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dormqr")]
            internal static extern int Dormqr(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, double* a, int lda, double* tau, double* c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dormqr_work")]
            internal static extern int DormqrWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, double* a, int lda, double* tau, double* c, int ldc, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dormrq")]
            internal static extern int Dormrq(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, double* a, int lda, double* tau, double* c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dormrq_work")]
            internal static extern int DormrqWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, double* a, int lda, double* tau, double* c, int ldc, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dormrz")]
            internal static extern int Dormrz(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, int l, double* a, int lda, double* tau, double* c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dormrz_work")]
            internal static extern int DormrzWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, int l, double* a, int lda, double* tau, double* c, int ldc, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dormtr")]
            internal static extern int Dormtr(BLAS.LAYOUT matrixLayout, sbyte side, sbyte uplo, BLAS.TRANS trans, int m, int n, double* a, int lda, double* tau, double* c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dormtr_work")]
            internal static extern int DormtrWork(BLAS.LAYOUT matrixLayout, sbyte side, sbyte uplo, BLAS.TRANS trans, int m, int n, double* a, int lda, double* tau, double* c, int ldc, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dpbcon")]
            internal static extern int Dpbcon(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, double* ab, int ldab, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dpbcon_work")]
            internal static extern int DpbconWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, double* ab, int ldab, double anorm, double* rcond, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dpbequ")]
            internal static extern int Dpbequ(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, double* ab, int ldab, double* s, double* scond, double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dpbequ_work")]
            internal static extern int DpbequWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, double* ab, int ldab, double* s, double* scond, double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dpbrfs")]
            internal static extern int Dpbrfs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, int nrhs, double* ab, int ldab, double* afb, int ldafb, double* b, int ldb, double* x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dpbrfs_work")]
            internal static extern int DpbrfsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, int nrhs, double* ab, int ldab, double* afb, int ldafb, double* b, int ldb, double* x, int ldx, double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dpbstf")]
            internal static extern int Dpbstf(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kb, double* bb, int ldbb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dpbstf_work")]
            internal static extern int DpbstfWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kb, double* bb, int ldbb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dpbsv")]
            internal static extern int Dpbsv(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, int nrhs, double* ab, int ldab, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dpbsv_work")]
            internal static extern int DpbsvWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, int nrhs, double* ab, int ldab, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dpbsvx")]
            internal static extern int Dpbsvx(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int kd, int nrhs, double* ab, int ldab, double* afb, int ldafb, sbyte* equed, double* s, double* b, int ldb, double* x, int ldx, double* rcond, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dpbsvx_work")]
            internal static extern int DpbsvxWork(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int kd, int nrhs, double* ab, int ldab, double* afb, int ldafb, sbyte* equed, double* s, double* b, int ldb, double* x, int ldx, double* rcond, double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dpbtrf")]
            internal static extern int Dpbtrf(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, double* ab, int ldab);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dpbtrf_work")]
            internal static extern int DpbtrfWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, double* ab, int ldab);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dpbtrs")]
            internal static extern int Dpbtrs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, int nrhs, double* ab, int ldab, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dpbtrs_work")]
            internal static extern int DpbtrsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, int nrhs, double* ab, int ldab, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dpftrf")]
            internal static extern int Dpftrf(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, double* a);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dpftrf_work")]
            internal static extern int DpftrfWork(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, double* a);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dpftri")]
            internal static extern int Dpftri(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, double* a);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dpftri_work")]
            internal static extern int DpftriWork(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, double* a);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dpftrs")]
            internal static extern int Dpftrs(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, int nrhs, double* a, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dpftrs_work")]
            internal static extern int DpftrsWork(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, int nrhs, double* a, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dpocon")]
            internal static extern int Dpocon(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dpocon_work")]
            internal static extern int DpoconWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda, double anorm, double* rcond, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dpoequ")]
            internal static extern int Dpoequ(BLAS.LAYOUT matrixLayout, int n, double* a, int lda, double* s, double* scond, double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dpoequ_work")]
            internal static extern int DpoequWork(BLAS.LAYOUT matrixLayout, int n, double* a, int lda, double* s, double* scond, double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dpoequb")]
            internal static extern int Dpoequb(BLAS.LAYOUT matrixLayout, int n, double* a, int lda, double* s, double* scond, double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dpoequb_work")]
            internal static extern int DpoequbWork(BLAS.LAYOUT matrixLayout, int n, double* a, int lda, double* s, double* scond, double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dporfs")]
            internal static extern int Dporfs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, double* af, int ldaf, double* b, int ldb, double* x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dporfs_work")]
            internal static extern int DporfsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, double* af, int ldaf, double* b, int ldb, double* x, int ldx, double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dporfsx")]
            internal static extern int Dporfsx(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte equed, int n, int nrhs, double* a, int lda, double* af, int ldaf, double* s, double* b, int ldb, double* x, int ldx, double* rcond, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dporfsx_work")]
            internal static extern int DporfsxWork(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte equed, int n, int nrhs, double* a, int lda, double* af, int ldaf, double* s, double* b, int ldb, double* x, int ldx, double* rcond, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dposv")]
            internal static extern int Dposv(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dposv_work")]
            internal static extern int DposvWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dposvx")]
            internal static extern int Dposvx(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, double* a, int lda, double* af, int ldaf, sbyte* equed, double* s, double* b, int ldb, double* x, int ldx, double* rcond, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dposvx_work")]
            internal static extern int DposvxWork(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, double* a, int lda, double* af, int ldaf, sbyte* equed, double* s, double* b, int ldb, double* x, int ldx, double* rcond, double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dposvxx")]
            internal static extern int Dposvxx(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, double* a, int lda, double* af, int ldaf, sbyte* equed, double* s, double* b, int ldb, double* x, int ldx, double* rcond, double* rpvgrw, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dposvxx_work")]
            internal static extern int DposvxxWork(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, double* a, int lda, double* af, int ldaf, sbyte* equed, double* s, double* b, int ldb, double* x, int ldx, double* rcond, double* rpvgrw, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dpotrf")]
            internal static extern int Dpotrf(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dpotrf2")]
            internal static extern int Dpotrf2(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dpotrf2_work")]
            internal static extern int Dpotrf2Work(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dpotrf_work")]
            internal static extern int DpotrfWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dpotri")]
            internal static extern int Dpotri(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dpotri_work")]
            internal static extern int DpotriWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dpotrs")]
            internal static extern int Dpotrs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dpotrs_work")]
            internal static extern int DpotrsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dppcon")]
            internal static extern int Dppcon(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* ap, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dppcon_work")]
            internal static extern int DppconWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* ap, double anorm, double* rcond, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dppequ")]
            internal static extern int Dppequ(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* ap, double* s, double* scond, double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dppequ_work")]
            internal static extern int DppequWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* ap, double* s, double* scond, double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dpprfs")]
            internal static extern int Dpprfs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* ap, double* afp, double* b, int ldb, double* x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dpprfs_work")]
            internal static extern int DpprfsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* ap, double* afp, double* b, int ldb, double* x, int ldx, double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dppsv")]
            internal static extern int Dppsv(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* ap, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dppsv_work")]
            internal static extern int DppsvWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* ap, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dppsvx")]
            internal static extern int Dppsvx(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, double* ap, double* afp, sbyte* equed, double* s, double* b, int ldb, double* x, int ldx, double* rcond, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dppsvx_work")]
            internal static extern int DppsvxWork(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, double* ap, double* afp, sbyte* equed, double* s, double* b, int ldb, double* x, int ldx, double* rcond, double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dpptrf")]
            internal static extern int Dpptrf(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dpptrf_work")]
            internal static extern int DpptrfWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dpptri")]
            internal static extern int Dpptri(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dpptri_work")]
            internal static extern int DpptriWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dpptrs")]
            internal static extern int Dpptrs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* ap, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dpptrs_work")]
            internal static extern int DpptrsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* ap, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dpstrf")]
            internal static extern int Dpstrf(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda, int* piv, int* rank, double tol);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dpstrf_work")]
            internal static extern int DpstrfWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda, int* piv, int* rank, double tol, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dptcon")]
            internal static extern int Dptcon(int n, double* d, double* e, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dptcon_work")]
            internal static extern int DptconWork(int n, double* d, double* e, double anorm, double* rcond, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dpteqr")]
            internal static extern int Dpteqr(BLAS.LAYOUT matrixLayout, sbyte compz, int n, double* d, double* e, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dpteqr_work")]
            internal static extern int DpteqrWork(BLAS.LAYOUT matrixLayout, sbyte compz, int n, double* d, double* e, double* z, int ldz, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dptrfs")]
            internal static extern int Dptrfs(BLAS.LAYOUT matrixLayout, int n, int nrhs, double* d, double* e, double* df, double* ef, double* b, int ldb, double* x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dptrfs_work")]
            internal static extern int DptrfsWork(BLAS.LAYOUT matrixLayout, int n, int nrhs, double* d, double* e, double* df, double* ef, double* b, int ldb, double* x, int ldx, double* ferr, double* berr, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dptsv")]
            internal static extern int Dptsv(BLAS.LAYOUT matrixLayout, int n, int nrhs, double* d, double* e, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dptsv_work")]
            internal static extern int DptsvWork(BLAS.LAYOUT matrixLayout, int n, int nrhs, double* d, double* e, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dptsvx")]
            internal static extern int Dptsvx(BLAS.LAYOUT matrixLayout, sbyte fact, int n, int nrhs, double* d, double* e, double* df, double* ef, double* b, int ldb, double* x, int ldx, double* rcond, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dptsvx_work")]
            internal static extern int DptsvxWork(BLAS.LAYOUT matrixLayout, sbyte fact, int n, int nrhs, double* d, double* e, double* df, double* ef, double* b, int ldb, double* x, int ldx, double* rcond, double* ferr, double* berr, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dpttrf")]
            internal static extern int Dpttrf(int n, double* d, double* e);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dpttrf_work")]
            internal static extern int DpttrfWork(int n, double* d, double* e);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dpttrs")]
            internal static extern int Dpttrs(BLAS.LAYOUT matrixLayout, int n, int nrhs, double* d, double* e, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dpttrs_work")]
            internal static extern int DpttrsWork(BLAS.LAYOUT matrixLayout, int n, int nrhs, double* d, double* e, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsbev")]
            internal static extern int Dsbev(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, double* ab, int ldab, double* w, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsbev_work")]
            internal static extern int DsbevWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, double* ab, int ldab, double* w, double* z, int ldz, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsbevd")]
            internal static extern int Dsbevd(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, double* ab, int ldab, double* w, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsbevd_work")]
            internal static extern int DsbevdWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, double* ab, int ldab, double* w, double* z, int ldz, double* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsbevx")]
            internal static extern int Dsbevx(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, int kd, double* ab, int ldab, double* q, int ldq, double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsbevx_work")]
            internal static extern int DsbevxWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, int kd, double* ab, int ldab, double* q, int ldq, double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, double* work, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsbgst")]
            internal static extern int Dsbgst(BLAS.LAYOUT matrixLayout, sbyte vect, sbyte uplo, int n, int ka, int kb, double* ab, int ldab, double* bb, int ldbb, double* x, int ldx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsbgst_work")]
            internal static extern int DsbgstWork(BLAS.LAYOUT matrixLayout, sbyte vect, sbyte uplo, int n, int ka, int kb, double* ab, int ldab, double* bb, int ldbb, double* x, int ldx, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsbgv")]
            internal static extern int Dsbgv(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int ka, int kb, double* ab, int ldab, double* bb, int ldbb, double* w, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsbgv_work")]
            internal static extern int DsbgvWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int ka, int kb, double* ab, int ldab, double* bb, int ldbb, double* w, double* z, int ldz, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsbgvd")]
            internal static extern int Dsbgvd(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int ka, int kb, double* ab, int ldab, double* bb, int ldbb, double* w, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsbgvd_work")]
            internal static extern int DsbgvdWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int ka, int kb, double* ab, int ldab, double* bb, int ldbb, double* w, double* z, int ldz, double* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsbgvx")]
            internal static extern int Dsbgvx(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, int ka, int kb, double* ab, int ldab, double* bb, int ldbb, double* q, int ldq, double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsbgvx_work")]
            internal static extern int DsbgvxWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, int ka, int kb, double* ab, int ldab, double* bb, int ldbb, double* q, int ldq, double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, double* work, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsbtrd")]
            internal static extern int Dsbtrd(BLAS.LAYOUT matrixLayout, sbyte vect, sbyte uplo, int n, int kd, double* ab, int ldab, double* d, double* e, double* q, int ldq);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsbtrd_work")]
            internal static extern int DsbtrdWork(BLAS.LAYOUT matrixLayout, sbyte vect, sbyte uplo, int n, int kd, double* ab, int ldab, double* d, double* e, double* q, int ldq, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsfrk")]
            internal static extern int Dsfrk(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, BLAS.TRANS trans, int n, int k, double alpha, double* a, int lda, double beta, double* c);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsfrk_work")]
            internal static extern int DsfrkWork(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, BLAS.TRANS trans, int n, int k, double alpha, double* a, int lda, double beta, double* c);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsgesv")]
            internal static extern int Dsgesv(BLAS.LAYOUT matrixLayout, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb, double* x, int ldx, int* iter);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsgesv_work")]
            internal static extern int DsgesvWork(BLAS.LAYOUT matrixLayout, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb, double* x, int ldx, double* work, float* swork, int* iter);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dspcon")]
            internal static extern int Dspcon(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* ap, int* ipiv, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dspcon_work")]
            internal static extern int DspconWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* ap, int* ipiv, double anorm, double* rcond, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dspev")]
            internal static extern int Dspev(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, double* ap, double* w, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dspev_work")]
            internal static extern int DspevWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, double* ap, double* w, double* z, int ldz, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dspevd")]
            internal static extern int Dspevd(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, double* ap, double* w, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dspevd_work")]
            internal static extern int DspevdWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, double* ap, double* w, double* z, int ldz, double* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dspevx")]
            internal static extern int Dspevx(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, double* ap, double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dspevx_work")]
            internal static extern int DspevxWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, double* ap, double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, double* work, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dspgst")]
            internal static extern int Dspgst(BLAS.LAYOUT matrixLayout, int itype, sbyte uplo, int n, double* ap, double* bp);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dspgst_work")]
            internal static extern int DspgstWork(BLAS.LAYOUT matrixLayout, int itype, sbyte uplo, int n, double* ap, double* bp);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dspgv")]
            internal static extern int Dspgv(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, double* ap, double* bp, double* w, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dspgv_work")]
            internal static extern int DspgvWork(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, double* ap, double* bp, double* w, double* z, int ldz, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dspgvd")]
            internal static extern int Dspgvd(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, double* ap, double* bp, double* w, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dspgvd_work")]
            internal static extern int DspgvdWork(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, double* ap, double* bp, double* w, double* z, int ldz, double* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dspgvx")]
            internal static extern int Dspgvx(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte range, sbyte uplo, int n, double* ap, double* bp, double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dspgvx_work")]
            internal static extern int DspgvxWork(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte range, sbyte uplo, int n, double* ap, double* bp, double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, double* work, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsposv")]
            internal static extern int Dsposv(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, double* b, int ldb, double* x, int ldx, int* iter);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsposv_work")]
            internal static extern int DsposvWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, double* b, int ldb, double* x, int ldx, double* work, float* swork, int* iter);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsprfs")]
            internal static extern int Dsprfs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* ap, double* afp, int* ipiv, double* b, int ldb, double* x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsprfs_work")]
            internal static extern int DsprfsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* ap, double* afp, int* ipiv, double* b, int ldb, double* x, int ldx, double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dspsv")]
            internal static extern int Dspsv(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* ap, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dspsv_work")]
            internal static extern int DspsvWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* ap, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dspsvx")]
            internal static extern int Dspsvx(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, double* ap, double* afp, int* ipiv, double* b, int ldb, double* x, int ldx, double* rcond, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dspsvx_work")]
            internal static extern int DspsvxWork(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, double* ap, double* afp, int* ipiv, double* b, int ldb, double* x, int ldx, double* rcond, double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsptrd")]
            internal static extern int Dsptrd(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* ap, double* d, double* e, double* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsptrd_work")]
            internal static extern int DsptrdWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* ap, double* d, double* e, double* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsptrf")]
            internal static extern int Dsptrf(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* ap, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsptrf_work")]
            internal static extern int DsptrfWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* ap, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsptri")]
            internal static extern int Dsptri(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* ap, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsptri_work")]
            internal static extern int DsptriWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* ap, int* ipiv, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsptrs")]
            internal static extern int Dsptrs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* ap, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsptrs_work")]
            internal static extern int DsptrsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* ap, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dstebz")]
            internal static extern int Dstebz(sbyte range, sbyte order, int n, double vl, double vu, int il, int iu, double abstol, double* d, double* e, int* m, int* nsplit, double* w, int* iblock, int* isplit);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dstebz_work")]
            internal static extern int DstebzWork(sbyte range, sbyte order, int n, double vl, double vu, int il, int iu, double abstol, double* d, double* e, int* m, int* nsplit, double* w, int* iblock, int* isplit, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dstedc")]
            internal static extern int Dstedc(BLAS.LAYOUT matrixLayout, sbyte compz, int n, double* d, double* e, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dstedc_work")]
            internal static extern int DstedcWork(BLAS.LAYOUT matrixLayout, sbyte compz, int n, double* d, double* e, double* z, int ldz, double* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dstegr")]
            internal static extern int Dstegr(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, int n, double* d, double* e, double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, int* isuppz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dstegr_work")]
            internal static extern int DstegrWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, int n, double* d, double* e, double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, int* isuppz, double* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dstein")]
            internal static extern int Dstein(BLAS.LAYOUT matrixLayout, int n, double* d, double* e, int m, double* w, int* iblock, int* isplit, double* z, int ldz, int* ifailv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dstein_work")]
            internal static extern int DsteinWork(BLAS.LAYOUT matrixLayout, int n, double* d, double* e, int m, double* w, int* iblock, int* isplit, double* z, int ldz, double* work, int* iwork, int* ifailv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dstemr")]
            internal static extern int Dstemr(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, int n, double* d, double* e, double vl, double vu, int il, int iu, int* m, double* w, double* z, int ldz, int nzc, int* isuppz, int* tryrac);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dstemr_work")]
            internal static extern int DstemrWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, int n, double* d, double* e, double vl, double vu, int il, int iu, int* m, double* w, double* z, int ldz, int nzc, int* isuppz, int* tryrac, double* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsteqr")]
            internal static extern int Dsteqr(BLAS.LAYOUT matrixLayout, sbyte compz, int n, double* d, double* e, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsteqr_work")]
            internal static extern int DsteqrWork(BLAS.LAYOUT matrixLayout, sbyte compz, int n, double* d, double* e, double* z, int ldz, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsterf")]
            internal static extern int Dsterf(int n, double* d, double* e);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsterf_work")]
            internal static extern int DsterfWork(int n, double* d, double* e);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dstev")]
            internal static extern int Dstev(BLAS.LAYOUT matrixLayout, sbyte jobz, int n, double* d, double* e, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dstev_work")]
            internal static extern int DstevWork(BLAS.LAYOUT matrixLayout, sbyte jobz, int n, double* d, double* e, double* z, int ldz, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dstevd")]
            internal static extern int Dstevd(BLAS.LAYOUT matrixLayout, sbyte jobz, int n, double* d, double* e, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dstevd_work")]
            internal static extern int DstevdWork(BLAS.LAYOUT matrixLayout, sbyte jobz, int n, double* d, double* e, double* z, int ldz, double* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dstevr")]
            internal static extern int Dstevr(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, int n, double* d, double* e, double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, int* isuppz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dstevr_work")]
            internal static extern int DstevrWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, int n, double* d, double* e, double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, int* isuppz, double* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dstevx")]
            internal static extern int Dstevx(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, int n, double* d, double* e, double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dstevx_work")]
            internal static extern int DstevxWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, int n, double* d, double* e, double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, double* work, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsycon")]
            internal static extern int Dsycon(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda, int* ipiv, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsycon_work")]
            internal static extern int DsyconWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda, int* ipiv, double anorm, double* rcond, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsyconv")]
            internal static extern int Dsyconv(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte way, int n, double* a, int lda, int* ipiv, double* e);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsyconv_work")]
            internal static extern int DsyconvWork(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte way, int n, double* a, int lda, int* ipiv, double* e);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsyequb")]
            internal static extern int Dsyequb(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda, double* s, double* scond, double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsyequb_work")]
            internal static extern int DsyequbWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda, double* s, double* scond, double* amax, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsyev")]
            internal static extern int Dsyev(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, double* a, int lda, double* w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsyev_work")]
            internal static extern int DsyevWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, double* a, int lda, double* w, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsyevd")]
            internal static extern int Dsyevd(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, double* a, int lda, double* w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsyevd_work")]
            internal static extern int DsyevdWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, double* a, int lda, double* w, double* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsyevr")]
            internal static extern int Dsyevr(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, double* a, int lda, double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, int* isuppz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsyevr_work")]
            internal static extern int DsyevrWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, double* a, int lda, double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, int* isuppz, double* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsyevx")]
            internal static extern int Dsyevx(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, double* a, int lda, double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsyevx_work")]
            internal static extern int DsyevxWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, double* a, int lda, double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, double* work, int lwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsygst")]
            internal static extern int Dsygst(BLAS.LAYOUT matrixLayout, int itype, sbyte uplo, int n, double* a, int lda, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsygst_work")]
            internal static extern int DsygstWork(BLAS.LAYOUT matrixLayout, int itype, sbyte uplo, int n, double* a, int lda, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsygv")]
            internal static extern int Dsygv(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, double* a, int lda, double* b, int ldb, double* w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsygv_work")]
            internal static extern int DsygvWork(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, double* a, int lda, double* b, int ldb, double* w, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsygvd")]
            internal static extern int Dsygvd(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, double* a, int lda, double* b, int ldb, double* w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsygvd_work")]
            internal static extern int DsygvdWork(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, double* a, int lda, double* b, int ldb, double* w, double* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsygvx")]
            internal static extern int Dsygvx(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte range, sbyte uplo, int n, double* a, int lda, double* b, int ldb, double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsygvx_work")]
            internal static extern int DsygvxWork(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte range, sbyte uplo, int n, double* a, int lda, double* b, int ldb, double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, double* work, int lwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsyrfs")]
            internal static extern int Dsyrfs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, double* af, int ldaf, int* ipiv, double* b, int ldb, double* x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsyrfs_work")]
            internal static extern int DsyrfsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, double* af, int ldaf, int* ipiv, double* b, int ldb, double* x, int ldx, double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsyrfsx")]
            internal static extern int Dsyrfsx(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte equed, int n, int nrhs, double* a, int lda, double* af, int ldaf, int* ipiv, double* s, double* b, int ldb, double* x, int ldx, double* rcond, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsyrfsx_work")]
            internal static extern int DsyrfsxWork(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte equed, int n, int nrhs, double* a, int lda, double* af, int ldaf, int* ipiv, double* s, double* b, int ldb, double* x, int ldx, double* rcond, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsysv")]
            internal static extern int Dsysv(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsysv_rook")]
            internal static extern int DsysvRook(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsysv_rook_work")]
            internal static extern int DsysvRookWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsysv_work")]
            internal static extern int DsysvWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsysvx")]
            internal static extern int Dsysvx(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, double* a, int lda, double* af, int ldaf, int* ipiv, double* b, int ldb, double* x, int ldx, double* rcond, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsysvx_work")]
            internal static extern int DsysvxWork(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, double* a, int lda, double* af, int ldaf, int* ipiv, double* b, int ldb, double* x, int ldx, double* rcond, double* ferr, double* berr, double* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsysvxx")]
            internal static extern int Dsysvxx(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, double* a, int lda, double* af, int ldaf, int* ipiv, sbyte* equed, double* s, double* b, int ldb, double* x, int ldx, double* rcond, double* rpvgrw, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsysvxx_work")]
            internal static extern int DsysvxxWork(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, double* a, int lda, double* af, int ldaf, int* ipiv, sbyte* equed, double* s, double* b, int ldb, double* x, int ldx, double* rcond, double* rpvgrw, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsyswapr")]
            internal static extern int Dsyswapr(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda, int i1, int i2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsyswapr_work")]
            internal static extern int DsyswaprWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda, int i1, int i2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsytrd")]
            internal static extern int Dsytrd(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda, double* d, double* e, double* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsytrd_work")]
            internal static extern int DsytrdWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda, double* d, double* e, double* tau, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsytrf")]
            internal static extern int Dsytrf(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsytrf_rook")]
            internal static extern int DsytrfRook(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsytrf_rook_work")]
            internal static extern int DsytrfRookWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda, int* ipiv, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsytrf_work")]
            internal static extern int DsytrfWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda, int* ipiv, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsytri")]
            internal static extern int Dsytri(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsytri2")]
            internal static extern int Dsytri2(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsytri2_work")]
            internal static extern int Dsytri2Work(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda, int* ipiv, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsytri2x")]
            internal static extern int Dsytri2x(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda, int* ipiv, int nb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsytri2x_work")]
            internal static extern int Dsytri2xWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda, int* ipiv, double* work, int nb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsytri_work")]
            internal static extern int DsytriWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda, int* ipiv, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsytrs")]
            internal static extern int Dsytrs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsytrs2")]
            internal static extern int Dsytrs2(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsytrs2_work")]
            internal static extern int Dsytrs2Work(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsytrs_rook")]
            internal static extern int DsytrsRook(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsytrs_rook_work")]
            internal static extern int DsytrsRookWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsytrs_work")]
            internal static extern int DsytrsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dtbcon")]
            internal static extern int Dtbcon(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int n, int kd, double* ab, int ldab, double* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dtbcon_work")]
            internal static extern int DtbconWork(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int n, int kd, double* ab, int ldab, double* rcond, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dtbrfs")]
            internal static extern int Dtbrfs(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int kd, int nrhs, double* ab, int ldab, double* b, int ldb, double* x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dtbrfs_work")]
            internal static extern int DtbrfsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int kd, int nrhs, double* ab, int ldab, double* b, int ldb, double* x, int ldx, double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dtbtrs")]
            internal static extern int Dtbtrs(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int kd, int nrhs, double* ab, int ldab, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dtbtrs_work")]
            internal static extern int DtbtrsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int kd, int nrhs, double* ab, int ldab, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dtfsm")]
            internal static extern int Dtfsm(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte side, sbyte uplo, BLAS.TRANS trans, sbyte diag, int m, int n, double alpha, double* a, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dtfsm_work")]
            internal static extern int DtfsmWork(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte side, sbyte uplo, BLAS.TRANS trans, sbyte diag, int m, int n, double alpha, double* a, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dtftri")]
            internal static extern int Dtftri(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, sbyte diag, int n, double* a);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dtftri_work")]
            internal static extern int DtftriWork(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, sbyte diag, int n, double* a);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dtfttp")]
            internal static extern int Dtfttp(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, double* arf, double* ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dtfttp_work")]
            internal static extern int DtfttpWork(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, double* arf, double* ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dtfttr")]
            internal static extern int Dtfttr(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, double* arf, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dtfttr_work")]
            internal static extern int DtfttrWork(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, double* arf, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dtgevc")]
            internal static extern int Dtgevc(BLAS.LAYOUT matrixLayout, sbyte side, sbyte howmny, int* select, int n, double* s, int lds, double* p, int ldp, double* vl, int ldvl, double* vr, int ldvr, int mm, int* m);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dtgevc_work")]
            internal static extern int DtgevcWork(BLAS.LAYOUT matrixLayout, sbyte side, sbyte howmny, int* select, int n, double* s, int lds, double* p, int ldp, double* vl, int ldvl, double* vr, int ldvr, int mm, int* m, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dtgexc")]
            internal static extern int Dtgexc(BLAS.LAYOUT matrixLayout, int wantq, int wantz, int n, double* a, int lda, double* b, int ldb, double* q, int ldq, double* z, int ldz, int* ifst, int* ilst);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dtgexc_work")]
            internal static extern int DtgexcWork(BLAS.LAYOUT matrixLayout, int wantq, int wantz, int n, double* a, int lda, double* b, int ldb, double* q, int ldq, double* z, int ldz, int* ifst, int* ilst, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dtgsen")]
            internal static extern int Dtgsen(BLAS.LAYOUT matrixLayout, int ijob, int wantq, int wantz, int* select, int n, double* a, int lda, double* b, int ldb, double* alphar, double* alphai, double* beta, double* q, int ldq, double* z, int ldz, int* m, double* pl, double* pr, double* dif);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dtgsen_work")]
            internal static extern int DtgsenWork(BLAS.LAYOUT matrixLayout, int ijob, int wantq, int wantz, int* select, int n, double* a, int lda, double* b, int ldb, double* alphar, double* alphai, double* beta, double* q, int ldq, double* z, int ldz, int* m, double* pl, double* pr, double* dif, double* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dtgsja")]
            internal static extern int Dtgsja(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, int k, int l, double* a, int lda, double* b, int ldb, double tola, double tolb, double* alpha, double* beta, double* u, int ldu, double* v, int ldv, double* q, int ldq, int* ncycle);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dtgsja_work")]
            internal static extern int DtgsjaWork(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, int k, int l, double* a, int lda, double* b, int ldb, double tola, double tolb, double* alpha, double* beta, double* u, int ldu, double* v, int ldv, double* q, int ldq, double* work, int* ncycle);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dtgsna")]
            internal static extern int Dtgsna(BLAS.LAYOUT matrixLayout, sbyte job, sbyte howmny, int* select, int n, double* a, int lda, double* b, int ldb, double* vl, int ldvl, double* vr, int ldvr, double* s, double* dif, int mm, int* m);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dtgsna_work")]
            internal static extern int DtgsnaWork(BLAS.LAYOUT matrixLayout, sbyte job, sbyte howmny, int* select, int n, double* a, int lda, double* b, int ldb, double* vl, int ldvl, double* vr, int ldvr, double* s, double* dif, int mm, int* m, double* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dtgsyl")]
            internal static extern int Dtgsyl(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int ijob, int m, int n, double* a, int lda, double* b, int ldb, double* c, int ldc, double* d, int ldd, double* e, int lde, double* f, int ldf, double* scale, double* dif);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dtgsyl_work")]
            internal static extern int DtgsylWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int ijob, int m, int n, double* a, int lda, double* b, int ldb, double* c, int ldc, double* d, int ldd, double* e, int lde, double* f, int ldf, double* scale, double* dif, double* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dtpcon")]
            internal static extern int Dtpcon(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int n, double* ap, double* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dtpcon_work")]
            internal static extern int DtpconWork(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int n, double* ap, double* rcond, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dtpmqrt")]
            internal static extern int Dtpmqrt(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, int l, int nb, double* v, int ldv, double* t, int ldt, double* a, int lda, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dtpmqrt_work")]
            internal static extern int DtpmqrtWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, int l, int nb, double* v, int ldv, double* t, int ldt, double* a, int lda, double* b, int ldb, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dtpqrt")]
            internal static extern int Dtpqrt(BLAS.LAYOUT matrixLayout, int m, int n, int l, int nb, double* a, int lda, double* b, int ldb, double* t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dtpqrt2")]
            internal static extern int Dtpqrt2(BLAS.LAYOUT matrixLayout, int m, int n, int l, double* a, int lda, double* b, int ldb, double* t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dtpqrt2_work")]
            internal static extern int Dtpqrt2Work(BLAS.LAYOUT matrixLayout, int m, int n, int l, double* a, int lda, double* b, int ldb, double* t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dtpqrt_work")]
            internal static extern int DtpqrtWork(BLAS.LAYOUT matrixLayout, int m, int n, int l, int nb, double* a, int lda, double* b, int ldb, double* t, int ldt, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dtprfb")]
            internal static extern int Dtprfb(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, sbyte direct, sbyte storev, int m, int n, int k, int l, double* v, int ldv, double* t, int ldt, double* a, int lda, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dtprfb_work")]
            internal static extern int DtprfbWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, sbyte direct, sbyte storev, int m, int n, int k, int l, double* v, int ldv, double* t, int ldt, double* a, int lda, double* b, int ldb, double* work, int ldwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dtprfs")]
            internal static extern int Dtprfs(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, double* ap, double* b, int ldb, double* x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dtprfs_work")]
            internal static extern int DtprfsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, double* ap, double* b, int ldb, double* x, int ldx, double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dtptri")]
            internal static extern int Dtptri(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte diag, int n, double* ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dtptri_work")]
            internal static extern int DtptriWork(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte diag, int n, double* ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dtptrs")]
            internal static extern int Dtptrs(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, double* ap, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dtptrs_work")]
            internal static extern int DtptrsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, double* ap, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dtpttf")]
            internal static extern int Dtpttf(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, double* ap, double* arf);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dtpttf_work")]
            internal static extern int DtpttfWork(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, double* ap, double* arf);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dtpttr")]
            internal static extern int Dtpttr(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* ap, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dtpttr_work")]
            internal static extern int DtpttrWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* ap, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dtrcon")]
            internal static extern int Dtrcon(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int n, double* a, int lda, double* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dtrcon_work")]
            internal static extern int DtrconWork(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int n, double* a, int lda, double* rcond, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dtrevc")]
            internal static extern int Dtrevc(BLAS.LAYOUT matrixLayout, sbyte side, sbyte howmny, int* select, int n, double* t, int ldt, double* vl, int ldvl, double* vr, int ldvr, int mm, int* m);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dtrevc_work")]
            internal static extern int DtrevcWork(BLAS.LAYOUT matrixLayout, sbyte side, sbyte howmny, int* select, int n, double* t, int ldt, double* vl, int ldvl, double* vr, int ldvr, int mm, int* m, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dtrexc")]
            internal static extern int Dtrexc(BLAS.LAYOUT matrixLayout, sbyte compq, int n, double* t, int ldt, double* q, int ldq, int* ifst, int* ilst);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dtrexc_work")]
            internal static extern int DtrexcWork(BLAS.LAYOUT matrixLayout, sbyte compq, int n, double* t, int ldt, double* q, int ldq, int* ifst, int* ilst, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dtrrfs")]
            internal static extern int Dtrrfs(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, double* a, int lda, double* b, int ldb, double* x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dtrrfs_work")]
            internal static extern int DtrrfsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, double* a, int lda, double* b, int ldb, double* x, int ldx, double* ferr, double* berr, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dtrsen")]
            internal static extern int Dtrsen(BLAS.LAYOUT matrixLayout, sbyte job, sbyte compq, int* select, int n, double* t, int ldt, double* q, int ldq, double* wr, double* wi, int* m, double* s, double* sep);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dtrsen_work")]
            internal static extern int DtrsenWork(BLAS.LAYOUT matrixLayout, sbyte job, sbyte compq, int* select, int n, double* t, int ldt, double* q, int ldq, double* wr, double* wi, int* m, double* s, double* sep, double* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dtrsna")]
            internal static extern int Dtrsna(BLAS.LAYOUT matrixLayout, sbyte job, sbyte howmny, int* select, int n, double* t, int ldt, double* vl, int ldvl, double* vr, int ldvr, double* s, double* sep, int mm, int* m);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dtrsna_work")]
            internal static extern int DtrsnaWork(BLAS.LAYOUT matrixLayout, sbyte job, sbyte howmny, int* select, int n, double* t, int ldt, double* vl, int ldvl, double* vr, int ldvr, double* s, double* sep, int mm, int* m, double* work, int ldwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dtrsyl")]
            internal static extern int Dtrsyl(BLAS.LAYOUT matrixLayout, sbyte trana, sbyte tranb, int isgn, int m, int n, double* a, int lda, double* b, int ldb, double* c, int ldc, double* scale);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dtrsyl_work")]
            internal static extern int DtrsylWork(BLAS.LAYOUT matrixLayout, sbyte trana, sbyte tranb, int isgn, int m, int n, double* a, int lda, double* b, int ldb, double* c, int ldc, double* scale);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dtrtri")]
            internal static extern int Dtrtri(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte diag, int n, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dtrtri_work")]
            internal static extern int DtrtriWork(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte diag, int n, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dtrtrs")]
            internal static extern int Dtrtrs(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, double* a, int lda, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dtrtrs_work")]
            internal static extern int DtrtrsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, double* a, int lda, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dtrttf")]
            internal static extern int Dtrttf(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, double* a, int lda, double* arf);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dtrttf_work")]
            internal static extern int DtrttfWork(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, double* a, int lda, double* arf);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dtrttp")]
            internal static extern int Dtrttp(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda, double* ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dtrttp_work")]
            internal static extern int DtrttpWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda, double* ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dtzrzf")]
            internal static extern int Dtzrzf(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, double* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dtzrzf_work")]
            internal static extern int DtzrzfWork(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, double* tau, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_mkl_cgetrfnpi")]
            internal static extern int MklCgetrfnpi(BLAS.LAYOUT matrixLayout, int m, int n, int nfact, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_mkl_cgetrfnpi_work")]
            internal static extern int MklCgetrfnpiWork(BLAS.LAYOUT matrixLayout, int m, int n, int nfact, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_mkl_ctppack")]
            internal static extern int MklCtppack(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, int n, System.IntPtr ap, int i, int j, int rows, int cols, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_mkl_ctppack_work")]
            internal static extern int MklCtppackWork(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, int n, System.IntPtr ap, int i, int j, int rows, int cols, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_mkl_ctpunpack")]
            internal static extern int MklCtpunpack(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, int n, System.IntPtr ap, int i, int j, int rows, int cols, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_mkl_ctpunpack_work")]
            internal static extern int MklCtpunpackWork(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, int n, System.IntPtr ap, int i, int j, int rows, int cols, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_mkl_dgetrfnpi")]
            internal static extern int MklDgetrfnpi(BLAS.LAYOUT matrixLayout, int m, int n, int nfact, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_mkl_dgetrfnpi_work")]
            internal static extern int MklDgetrfnpiWork(BLAS.LAYOUT matrixLayout, int m, int n, int nfact, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_mkl_dtppack")]
            internal static extern int MklDtppack(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, int n, double* ap, int i, int j, int rows, int cols, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_mkl_dtppack_work")]
            internal static extern int MklDtppackWork(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, int n, double* ap, int i, int j, int rows, int cols, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_mkl_dtpunpack")]
            internal static extern int MklDtpunpack(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, int n, double* ap, int i, int j, int rows, int cols, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_mkl_dtpunpack_work")]
            internal static extern int MklDtpunpackWork(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, int n, double* ap, int i, int j, int rows, int cols, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_mkl_sgetrfnpi")]
            internal static extern int MklSgetrfnpi(BLAS.LAYOUT matrixLayout, int m, int n, int nfact, float* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_mkl_sgetrfnpi_work")]
            internal static extern int MklSgetrfnpiWork(BLAS.LAYOUT matrixLayout, int m, int n, int nfact, float* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_mkl_stppack")]
            internal static extern int MklStppack(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, int n, float* ap, int i, int j, int rows, int cols, float* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_mkl_stppack_work")]
            internal static extern int MklStppackWork(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, int n, float* ap, int i, int j, int rows, int cols, float* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_mkl_stpunpack")]
            internal static extern int MklStpunpack(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, int n, float* ap, int i, int j, int rows, int cols, float* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_mkl_stpunpack_work")]
            internal static extern int MklStpunpackWork(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, int n, float* ap, int i, int j, int rows, int cols, float* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_mkl_zgetrfnpi")]
            internal static extern int MklZgetrfnpi(BLAS.LAYOUT matrixLayout, int m, int n, int nfact, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_mkl_zgetrfnpi_work")]
            internal static extern int MklZgetrfnpiWork(BLAS.LAYOUT matrixLayout, int m, int n, int nfact, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_mkl_ztppack")]
            internal static extern int MklZtppack(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, int n, System.IntPtr ap, int i, int j, int rows, int cols, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_mkl_ztppack_work")]
            internal static extern int MklZtppackWork(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, int n, System.IntPtr ap, int i, int j, int rows, int cols, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_mkl_ztpunpack")]
            internal static extern int MklZtpunpack(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, int n, System.IntPtr ap, int i, int j, int rows, int cols, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_mkl_ztpunpack_work")]
            internal static extern int MklZtpunpackWork(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, int n, System.IntPtr ap, int i, int j, int rows, int cols, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sbbcsd")]
            internal static extern int Sbbcsd(BLAS.LAYOUT matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, sbyte jobv2t, BLAS.TRANS trans, int m, int p, int q, float* theta, float* phi, float* u1, int ldu1, float* u2, int ldu2, float* v1t, int ldv1t, float* v2t, int ldv2t, float* b11d, float* b11e, float* b12d, float* b12e, float* b21d, float* b21e, float* b22d, float* b22e);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sbbcsd_work")]
            internal static extern int SbbcsdWork(BLAS.LAYOUT matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, sbyte jobv2t, BLAS.TRANS trans, int m, int p, int q, float* theta, float* phi, float* u1, int ldu1, float* u2, int ldu2, float* v1t, int ldv1t, float* v2t, int ldv2t, float* b11d, float* b11e, float* b12d, float* b12e, float* b21d, float* b21e, float* b22d, float* b22e, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sbdsdc")]
            internal static extern int Sbdsdc(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte compq, int n, float* d, float* e, float* u, int ldu, float* vt, int ldvt, float* q, int* iq);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sbdsdc_work")]
            internal static extern int SbdsdcWork(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte compq, int n, float* d, float* e, float* u, int ldu, float* vt, int ldvt, float* q, int* iq, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sbdsqr")]
            internal static extern int Sbdsqr(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int ncvt, int nru, int ncc, float* d, float* e, float* vt, int ldvt, float* u, int ldu, float* c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sbdsqr_work")]
            internal static extern int SbdsqrWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int ncvt, int nru, int ncc, float* d, float* e, float* vt, int ldvt, float* u, int ldu, float* c, int ldc, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sbdsvdx")]
            internal static extern int Sbdsvdx(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte jobz, sbyte range, int n, float* d, float* e, float vl, float vu, int il, int iu, int* ns, float* s, float* z, int ldz, int* superb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sbdsvdx_work")]
            internal static extern int SbdsvdxWork(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte jobz, sbyte range, int n, float* d, float* e, float vl, float vu, int il, int iu, int* ns, float* s, float* z, int ldz, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sdisna")]
            internal static extern int Sdisna(sbyte job, int m, int n, float* d, float* sep);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sdisna_work")]
            internal static extern int SdisnaWork(sbyte job, int m, int n, float* d, float* sep);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgbbrd")]
            internal static extern int Sgbbrd(BLAS.LAYOUT matrixLayout, sbyte vect, int m, int n, int ncc, int kl, int ku, float* ab, int ldab, float* d, float* e, float* q, int ldq, float* pt, int ldpt, float* c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgbbrd_work")]
            internal static extern int SgbbrdWork(BLAS.LAYOUT matrixLayout, sbyte vect, int m, int n, int ncc, int kl, int ku, float* ab, int ldab, float* d, float* e, float* q, int ldq, float* pt, int ldpt, float* c, int ldc, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgbcon")]
            internal static extern int Sgbcon(BLAS.LAYOUT matrixLayout, sbyte norm, int n, int kl, int ku, float* ab, int ldab, int* ipiv, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgbcon_work")]
            internal static extern int SgbconWork(BLAS.LAYOUT matrixLayout, sbyte norm, int n, int kl, int ku, float* ab, int ldab, int* ipiv, float anorm, float* rcond, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgbequ")]
            internal static extern int Sgbequ(BLAS.LAYOUT matrixLayout, int m, int n, int kl, int ku, float* ab, int ldab, float* r, float* c, float* rowcnd, float* colcnd, float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgbequ_work")]
            internal static extern int SgbequWork(BLAS.LAYOUT matrixLayout, int m, int n, int kl, int ku, float* ab, int ldab, float* r, float* c, float* rowcnd, float* colcnd, float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgbequb")]
            internal static extern int Sgbequb(BLAS.LAYOUT matrixLayout, int m, int n, int kl, int ku, float* ab, int ldab, float* r, float* c, float* rowcnd, float* colcnd, float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgbequb_work")]
            internal static extern int SgbequbWork(BLAS.LAYOUT matrixLayout, int m, int n, int kl, int ku, float* ab, int ldab, float* r, float* c, float* rowcnd, float* colcnd, float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgbrfs")]
            internal static extern int Sgbrfs(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, float* ab, int ldab, float* afb, int ldafb, int* ipiv, float* b, int ldb, float* x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgbrfs_work")]
            internal static extern int SgbrfsWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, float* ab, int ldab, float* afb, int ldafb, int* ipiv, float* b, int ldb, float* x, int ldx, float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgbrfsx")]
            internal static extern int Sgbrfsx(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, sbyte equed, int n, int kl, int ku, int nrhs, float* ab, int ldab, float* afb, int ldafb, int* ipiv, float* r, float* c, float* b, int ldb, float* x, int ldx, float* rcond, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgbrfsx_work")]
            internal static extern int SgbrfsxWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, sbyte equed, int n, int kl, int ku, int nrhs, float* ab, int ldab, float* afb, int ldafb, int* ipiv, float* r, float* c, float* b, int ldb, float* x, int ldx, float* rcond, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgbsv")]
            internal static extern int Sgbsv(BLAS.LAYOUT matrixLayout, int n, int kl, int ku, int nrhs, float* ab, int ldab, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgbsv_work")]
            internal static extern int SgbsvWork(BLAS.LAYOUT matrixLayout, int n, int kl, int ku, int nrhs, float* ab, int ldab, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgbsvx")]
            internal static extern int Sgbsvx(BLAS.LAYOUT matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, float* ab, int ldab, float* afb, int ldafb, int* ipiv, sbyte* equed, float* r, float* c, float* b, int ldb, float* x, int ldx, float* rcond, float* ferr, float* berr, float* rpivot);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgbsvx_work")]
            internal static extern int SgbsvxWork(BLAS.LAYOUT matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, float* ab, int ldab, float* afb, int ldafb, int* ipiv, sbyte* equed, float* r, float* c, float* b, int ldb, float* x, int ldx, float* rcond, float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgbsvxx")]
            internal static extern int Sgbsvxx(BLAS.LAYOUT matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, float* ab, int ldab, float* afb, int ldafb, int* ipiv, sbyte* equed, float* r, float* c, float* b, int ldb, float* x, int ldx, float* rcond, float* rpvgrw, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgbsvxx_work")]
            internal static extern int SgbsvxxWork(BLAS.LAYOUT matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, float* ab, int ldab, float* afb, int ldafb, int* ipiv, sbyte* equed, float* r, float* c, float* b, int ldb, float* x, int ldx, float* rcond, float* rpvgrw, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgbtrf")]
            internal static extern int Sgbtrf(BLAS.LAYOUT matrixLayout, int m, int n, int kl, int ku, float* ab, int ldab, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgbtrf_work")]
            internal static extern int SgbtrfWork(BLAS.LAYOUT matrixLayout, int m, int n, int kl, int ku, float* ab, int ldab, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgbtrs")]
            internal static extern int Sgbtrs(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, float* ab, int ldab, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgbtrs_work")]
            internal static extern int SgbtrsWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, float* ab, int ldab, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgebak")]
            internal static extern int Sgebak(BLAS.LAYOUT matrixLayout, sbyte job, sbyte side, int n, int ilo, int ihi, float* scale, int m, float* v, int ldv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgebak_work")]
            internal static extern int SgebakWork(BLAS.LAYOUT matrixLayout, sbyte job, sbyte side, int n, int ilo, int ihi, float* scale, int m, float* v, int ldv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgebal")]
            internal static extern int Sgebal(BLAS.LAYOUT matrixLayout, sbyte job, int n, float* a, int lda, int* ilo, int* ihi, float* scale);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgebal_work")]
            internal static extern int SgebalWork(BLAS.LAYOUT matrixLayout, sbyte job, int n, float* a, int lda, int* ilo, int* ihi, float* scale);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgebrd")]
            internal static extern int Sgebrd(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda, float* d, float* e, float* tauq, float* taup);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgebrd_work")]
            internal static extern int SgebrdWork(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda, float* d, float* e, float* tauq, float* taup, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgecon")]
            internal static extern int Sgecon(BLAS.LAYOUT matrixLayout, sbyte norm, int n, float* a, int lda, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgecon_work")]
            internal static extern int SgeconWork(BLAS.LAYOUT matrixLayout, sbyte norm, int n, float* a, int lda, float anorm, float* rcond, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgeequ")]
            internal static extern int Sgeequ(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda, float* r, float* c, float* rowcnd, float* colcnd, float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgeequ_work")]
            internal static extern int SgeequWork(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda, float* r, float* c, float* rowcnd, float* colcnd, float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgeequb")]
            internal static extern int Sgeequb(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda, float* r, float* c, float* rowcnd, float* colcnd, float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgeequb_work")]
            internal static extern int SgeequbWork(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda, float* r, float* c, float* rowcnd, float* colcnd, float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgees")]
            internal static extern int Sgees(BLAS.LAYOUT matrixLayout, sbyte jobvs, sbyte sort, System.IntPtr select, int n, float* a, int lda, int* sdim, float* wr, float* wi, float* vs, int ldvs);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgees_work")]
            internal static extern int SgeesWork(BLAS.LAYOUT matrixLayout, sbyte jobvs, sbyte sort, System.IntPtr select, int n, float* a, int lda, int* sdim, float* wr, float* wi, float* vs, int ldvs, float* work, int lwork, int* bwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgeesx")]
            internal static extern int Sgeesx(BLAS.LAYOUT matrixLayout, sbyte jobvs, sbyte sort, System.IntPtr select, sbyte sense, int n, float* a, int lda, int* sdim, float* wr, float* wi, float* vs, int ldvs, float* rconde, float* rcondv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgeesx_work")]
            internal static extern int SgeesxWork(BLAS.LAYOUT matrixLayout, sbyte jobvs, sbyte sort, System.IntPtr select, sbyte sense, int n, float* a, int lda, int* sdim, float* wr, float* wi, float* vs, int ldvs, float* rconde, float* rcondv, float* work, int lwork, int* iwork, int liwork, int* bwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgeev")]
            internal static extern int Sgeev(BLAS.LAYOUT matrixLayout, sbyte jobvl, sbyte jobvr, int n, float* a, int lda, float* wr, float* wi, float* vl, int ldvl, float* vr, int ldvr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgeev_work")]
            internal static extern int SgeevWork(BLAS.LAYOUT matrixLayout, sbyte jobvl, sbyte jobvr, int n, float* a, int lda, float* wr, float* wi, float* vl, int ldvl, float* vr, int ldvr, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgeevx")]
            internal static extern int Sgeevx(BLAS.LAYOUT matrixLayout, sbyte balanc, sbyte jobvl, sbyte jobvr, sbyte sense, int n, float* a, int lda, float* wr, float* wi, float* vl, int ldvl, float* vr, int ldvr, int* ilo, int* ihi, float* scale, float* abnrm, float* rconde, float* rcondv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgeevx_work")]
            internal static extern int SgeevxWork(BLAS.LAYOUT matrixLayout, sbyte balanc, sbyte jobvl, sbyte jobvr, sbyte sense, int n, float* a, int lda, float* wr, float* wi, float* vl, int ldvl, float* vr, int ldvr, int* ilo, int* ihi, float* scale, float* abnrm, float* rconde, float* rcondv, float* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgehrd")]
            internal static extern int Sgehrd(BLAS.LAYOUT matrixLayout, int n, int ilo, int ihi, float* a, int lda, float* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgehrd_work")]
            internal static extern int SgehrdWork(BLAS.LAYOUT matrixLayout, int n, int ilo, int ihi, float* a, int lda, float* tau, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgejsv")]
            internal static extern int Sgejsv(BLAS.LAYOUT matrixLayout, sbyte joba, sbyte jobu, sbyte jobv, sbyte jobr, sbyte jobt, sbyte jobp, int m, int n, float* a, int lda, float* sva, float* u, int ldu, float* v, int ldv, float* stat, int* istat);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgejsv_work")]
            internal static extern int SgejsvWork(BLAS.LAYOUT matrixLayout, sbyte joba, sbyte jobu, sbyte jobv, sbyte jobr, sbyte jobt, sbyte jobp, int m, int n, float* a, int lda, float* sva, float* u, int ldu, float* v, int ldv, float* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgelq2")]
            internal static extern int Sgelq2(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda, float* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgelq2_work")]
            internal static extern int Sgelq2Work(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda, float* tau, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgelqf")]
            internal static extern int Sgelqf(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda, float* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgelqf_work")]
            internal static extern int SgelqfWork(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda, float* tau, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgels")]
            internal static extern int Sgels(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int m, int n, int nrhs, float* a, int lda, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgels_work")]
            internal static extern int SgelsWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int m, int n, int nrhs, float* a, int lda, float* b, int ldb, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgelsd")]
            internal static extern int Sgelsd(BLAS.LAYOUT matrixLayout, int m, int n, int nrhs, float* a, int lda, float* b, int ldb, float* s, float rcond, int* rank);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgelsd_work")]
            internal static extern int SgelsdWork(BLAS.LAYOUT matrixLayout, int m, int n, int nrhs, float* a, int lda, float* b, int ldb, float* s, float rcond, int* rank, float* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgelss")]
            internal static extern int Sgelss(BLAS.LAYOUT matrixLayout, int m, int n, int nrhs, float* a, int lda, float* b, int ldb, float* s, float rcond, int* rank);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgelss_work")]
            internal static extern int SgelssWork(BLAS.LAYOUT matrixLayout, int m, int n, int nrhs, float* a, int lda, float* b, int ldb, float* s, float rcond, int* rank, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgelsy")]
            internal static extern int Sgelsy(BLAS.LAYOUT matrixLayout, int m, int n, int nrhs, float* a, int lda, float* b, int ldb, int* jpvt, float rcond, int* rank);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgelsy_work")]
            internal static extern int SgelsyWork(BLAS.LAYOUT matrixLayout, int m, int n, int nrhs, float* a, int lda, float* b, int ldb, int* jpvt, float rcond, int* rank, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgemqrt")]
            internal static extern int Sgemqrt(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, int nb, float* v, int ldv, float* t, int ldt, float* c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgemqrt_work")]
            internal static extern int SgemqrtWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, int nb, float* v, int ldv, float* t, int ldt, float* c, int ldc, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgeqlf")]
            internal static extern int Sgeqlf(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda, float* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgeqlf_work")]
            internal static extern int SgeqlfWork(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda, float* tau, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgeqp3")]
            internal static extern int Sgeqp3(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda, int* jpvt, float* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgeqp3_work")]
            internal static extern int Sgeqp3Work(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda, int* jpvt, float* tau, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgeqpf")]
            internal static extern int Sgeqpf(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda, int* jpvt, float* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgeqpf_work")]
            internal static extern int SgeqpfWork(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda, int* jpvt, float* tau, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgeqr2")]
            internal static extern int Sgeqr2(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda, float* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgeqr2_work")]
            internal static extern int Sgeqr2Work(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda, float* tau, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgeqrf")]
            internal static extern int Sgeqrf(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda, float* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgeqrf_work")]
            internal static extern int SgeqrfWork(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda, float* tau, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgeqrfp")]
            internal static extern int Sgeqrfp(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda, float* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgeqrfp_work")]
            internal static extern int SgeqrfpWork(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda, float* tau, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgeqrt")]
            internal static extern int Sgeqrt(BLAS.LAYOUT matrixLayout, int m, int n, int nb, float* a, int lda, float* t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgeqrt2")]
            internal static extern int Sgeqrt2(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda, float* t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgeqrt2_work")]
            internal static extern int Sgeqrt2Work(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda, float* t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgeqrt3")]
            internal static extern int Sgeqrt3(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda, float* t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgeqrt3_work")]
            internal static extern int Sgeqrt3Work(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda, float* t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgeqrt_work")]
            internal static extern int SgeqrtWork(BLAS.LAYOUT matrixLayout, int m, int n, int nb, float* a, int lda, float* t, int ldt, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgerfs")]
            internal static extern int Sgerfs(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int nrhs, float* a, int lda, float* af, int ldaf, int* ipiv, float* b, int ldb, float* x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgerfs_work")]
            internal static extern int SgerfsWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int nrhs, float* a, int lda, float* af, int ldaf, int* ipiv, float* b, int ldb, float* x, int ldx, float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgerfsx")]
            internal static extern int Sgerfsx(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, sbyte equed, int n, int nrhs, float* a, int lda, float* af, int ldaf, int* ipiv, float* r, float* c, float* b, int ldb, float* x, int ldx, float* rcond, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgerfsx_work")]
            internal static extern int SgerfsxWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, sbyte equed, int n, int nrhs, float* a, int lda, float* af, int ldaf, int* ipiv, float* r, float* c, float* b, int ldb, float* x, int ldx, float* rcond, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgerqf")]
            internal static extern int Sgerqf(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda, float* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgerqf_work")]
            internal static extern int SgerqfWork(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda, float* tau, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgesdd")]
            internal static extern int Sgesdd(BLAS.LAYOUT matrixLayout, sbyte jobz, int m, int n, float* a, int lda, float* s, float* u, int ldu, float* vt, int ldvt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgesdd_work")]
            internal static extern int SgesddWork(BLAS.LAYOUT matrixLayout, sbyte jobz, int m, int n, float* a, int lda, float* s, float* u, int ldu, float* vt, int ldvt, float* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgesv")]
            internal static extern int Sgesv(BLAS.LAYOUT matrixLayout, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgesv_work")]
            internal static extern int SgesvWork(BLAS.LAYOUT matrixLayout, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgesvd")]
            internal static extern int Sgesvd(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobvt, int m, int n, float* a, int lda, float* s, float* u, int ldu, float* vt, int ldvt, float* superb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgesvd_work")]
            internal static extern int SgesvdWork(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobvt, int m, int n, float* a, int lda, float* s, float* u, int ldu, float* vt, int ldvt, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgesvdx")]
            internal static extern int Sgesvdx(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobvt, sbyte range, int m, int n, float* a, int lda, float vl, float vu, int il, int iu, int* ns, float* s, float* u, int ldu, float* vt, int ldvt, int* superb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgesvdx_work")]
            internal static extern int SgesvdxWork(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobvt, sbyte range, int m, int n, float* a, int lda, float vl, float vu, int il, int iu, int* ns, float* s, float* u, int ldu, float* vt, int ldvt, float* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgesvj")]
            internal static extern int Sgesvj(BLAS.LAYOUT matrixLayout, sbyte joba, sbyte jobu, sbyte jobv, int m, int n, float* a, int lda, float* sva, int mv, float* v, int ldv, float* stat);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgesvj_work")]
            internal static extern int SgesvjWork(BLAS.LAYOUT matrixLayout, sbyte joba, sbyte jobu, sbyte jobv, int m, int n, float* a, int lda, float* sva, int mv, float* v, int ldv, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgesvx")]
            internal static extern int Sgesvx(BLAS.LAYOUT matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int nrhs, float* a, int lda, float* af, int ldaf, int* ipiv, sbyte* equed, float* r, float* c, float* b, int ldb, float* x, int ldx, float* rcond, float* ferr, float* berr, float* rpivot);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgesvx_work")]
            internal static extern int SgesvxWork(BLAS.LAYOUT matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int nrhs, float* a, int lda, float* af, int ldaf, int* ipiv, sbyte* equed, float* r, float* c, float* b, int ldb, float* x, int ldx, float* rcond, float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgesvxx")]
            internal static extern int Sgesvxx(BLAS.LAYOUT matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int nrhs, float* a, int lda, float* af, int ldaf, int* ipiv, sbyte* equed, float* r, float* c, float* b, int ldb, float* x, int ldx, float* rcond, float* rpvgrw, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgesvxx_work")]
            internal static extern int SgesvxxWork(BLAS.LAYOUT matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int nrhs, float* a, int lda, float* af, int ldaf, int* ipiv, sbyte* equed, float* r, float* c, float* b, int ldb, float* x, int ldx, float* rcond, float* rpvgrw, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgetf2")]
            internal static extern int Sgetf2(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgetf2_work")]
            internal static extern int Sgetf2Work(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgetrf")]
            internal static extern int Sgetrf(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgetrf2")]
            internal static extern int Sgetrf2(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgetrf2_work")]
            internal static extern int Sgetrf2Work(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgetrf_work")]
            internal static extern int SgetrfWork(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgetri")]
            internal static extern int Sgetri(BLAS.LAYOUT matrixLayout, int n, float* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgetri_work")]
            internal static extern int SgetriWork(BLAS.LAYOUT matrixLayout, int n, float* a, int lda, int* ipiv, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgetrs")]
            internal static extern int Sgetrs(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgetrs_work")]
            internal static extern int SgetrsWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sggbak")]
            internal static extern int Sggbak(BLAS.LAYOUT matrixLayout, sbyte job, sbyte side, int n, int ilo, int ihi, float* lscale, float* rscale, int m, float* v, int ldv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sggbak_work")]
            internal static extern int SggbakWork(BLAS.LAYOUT matrixLayout, sbyte job, sbyte side, int n, int ilo, int ihi, float* lscale, float* rscale, int m, float* v, int ldv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sggbal")]
            internal static extern int Sggbal(BLAS.LAYOUT matrixLayout, sbyte job, int n, float* a, int lda, float* b, int ldb, int* ilo, int* ihi, float* lscale, float* rscale);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sggbal_work")]
            internal static extern int SggbalWork(BLAS.LAYOUT matrixLayout, sbyte job, int n, float* a, int lda, float* b, int ldb, int* ilo, int* ihi, float* lscale, float* rscale, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgges")]
            internal static extern int Sgges(BLAS.LAYOUT matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, System.IntPtr selctg, int n, float* a, int lda, float* b, int ldb, int* sdim, float* alphar, float* alphai, float* beta, float* vsl, int ldvsl, float* vsr, int ldvsr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgges3")]
            internal static extern int Sgges3(BLAS.LAYOUT matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, System.IntPtr selctg, int n, float* a, int lda, float* b, int ldb, int* sdim, float* alphar, float* alphai, float* beta, float* vsl, int ldvsl, float* vsr, int ldvsr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgges3_work")]
            internal static extern int Sgges3Work(BLAS.LAYOUT matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, System.IntPtr selctg, int n, float* a, int lda, float* b, int ldb, int* sdim, float* alphar, float* alphai, float* beta, float* vsl, int ldvsl, float* vsr, int ldvsr, float* work, int lwork, int* bwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgges_work")]
            internal static extern int SggesWork(BLAS.LAYOUT matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, System.IntPtr selctg, int n, float* a, int lda, float* b, int ldb, int* sdim, float* alphar, float* alphai, float* beta, float* vsl, int ldvsl, float* vsr, int ldvsr, float* work, int lwork, int* bwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sggesx")]
            internal static extern int Sggesx(BLAS.LAYOUT matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, System.IntPtr selctg, sbyte sense, int n, float* a, int lda, float* b, int ldb, int* sdim, float* alphar, float* alphai, float* beta, float* vsl, int ldvsl, float* vsr, int ldvsr, float* rconde, float* rcondv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sggesx_work")]
            internal static extern int SggesxWork(BLAS.LAYOUT matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, System.IntPtr selctg, sbyte sense, int n, float* a, int lda, float* b, int ldb, int* sdim, float* alphar, float* alphai, float* beta, float* vsl, int ldvsl, float* vsr, int ldvsr, float* rconde, float* rcondv, float* work, int lwork, int* iwork, int liwork, int* bwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sggev")]
            internal static extern int Sggev(BLAS.LAYOUT matrixLayout, sbyte jobvl, sbyte jobvr, int n, float* a, int lda, float* b, int ldb, float* alphar, float* alphai, float* beta, float* vl, int ldvl, float* vr, int ldvr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sggev3")]
            internal static extern int Sggev3(BLAS.LAYOUT matrixLayout, sbyte jobvl, sbyte jobvr, int n, float* a, int lda, float* b, int ldb, float* alphar, float* alphai, float* beta, float* vl, int ldvl, float* vr, int ldvr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sggev3_work")]
            internal static extern int Sggev3Work(BLAS.LAYOUT matrixLayout, sbyte jobvl, sbyte jobvr, int n, float* a, int lda, float* b, int ldb, float* alphar, float* alphai, float* beta, float* vl, int ldvl, float* vr, int ldvr, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sggev_work")]
            internal static extern int SggevWork(BLAS.LAYOUT matrixLayout, sbyte jobvl, sbyte jobvr, int n, float* a, int lda, float* b, int ldb, float* alphar, float* alphai, float* beta, float* vl, int ldvl, float* vr, int ldvr, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sggevx")]
            internal static extern int Sggevx(BLAS.LAYOUT matrixLayout, sbyte balanc, sbyte jobvl, sbyte jobvr, sbyte sense, int n, float* a, int lda, float* b, int ldb, float* alphar, float* alphai, float* beta, float* vl, int ldvl, float* vr, int ldvr, int* ilo, int* ihi, float* lscale, float* rscale, float* abnrm, float* bbnrm, float* rconde, float* rcondv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sggevx_work")]
            internal static extern int SggevxWork(BLAS.LAYOUT matrixLayout, sbyte balanc, sbyte jobvl, sbyte jobvr, sbyte sense, int n, float* a, int lda, float* b, int ldb, float* alphar, float* alphai, float* beta, float* vl, int ldvl, float* vr, int ldvr, int* ilo, int* ihi, float* lscale, float* rscale, float* abnrm, float* bbnrm, float* rconde, float* rcondv, float* work, int lwork, int* iwork, int* bwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sggglm")]
            internal static extern int Sggglm(BLAS.LAYOUT matrixLayout, int n, int m, int p, float* a, int lda, float* b, int ldb, float* d, float* x, float* y);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sggglm_work")]
            internal static extern int SggglmWork(BLAS.LAYOUT matrixLayout, int n, int m, int p, float* a, int lda, float* b, int ldb, float* d, float* x, float* y, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgghd3")]
            internal static extern int Sgghd3(BLAS.LAYOUT matrixLayout, sbyte compq, sbyte compz, int n, int ilo, int ihi, float* a, int lda, float* b, int ldb, float* q, int ldq, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgghd3_work")]
            internal static extern int Sgghd3Work(BLAS.LAYOUT matrixLayout, sbyte compq, sbyte compz, int n, int ilo, int ihi, float* a, int lda, float* b, int ldb, float* q, int ldq, float* z, int ldz, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgghrd")]
            internal static extern int Sgghrd(BLAS.LAYOUT matrixLayout, sbyte compq, sbyte compz, int n, int ilo, int ihi, float* a, int lda, float* b, int ldb, float* q, int ldq, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgghrd_work")]
            internal static extern int SgghrdWork(BLAS.LAYOUT matrixLayout, sbyte compq, sbyte compz, int n, int ilo, int ihi, float* a, int lda, float* b, int ldb, float* q, int ldq, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgglse")]
            internal static extern int Sgglse(BLAS.LAYOUT matrixLayout, int m, int n, int p, float* a, int lda, float* b, int ldb, float* c, float* d, float* x);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgglse_work")]
            internal static extern int SgglseWork(BLAS.LAYOUT matrixLayout, int m, int n, int p, float* a, int lda, float* b, int ldb, float* c, float* d, float* x, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sggqrf")]
            internal static extern int Sggqrf(BLAS.LAYOUT matrixLayout, int n, int m, int p, float* a, int lda, float* taua, float* b, int ldb, float* taub);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sggqrf_work")]
            internal static extern int SggqrfWork(BLAS.LAYOUT matrixLayout, int n, int m, int p, float* a, int lda, float* taua, float* b, int ldb, float* taub, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sggrqf")]
            internal static extern int Sggrqf(BLAS.LAYOUT matrixLayout, int m, int p, int n, float* a, int lda, float* taua, float* b, int ldb, float* taub);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sggrqf_work")]
            internal static extern int SggrqfWork(BLAS.LAYOUT matrixLayout, int m, int p, int n, float* a, int lda, float* taua, float* b, int ldb, float* taub, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sggsvd")]
            internal static extern int Sggsvd(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int n, int p, int* k, int* l, float* a, int lda, float* b, int ldb, float* alpha, float* beta, float* u, int ldu, float* v, int ldv, float* q, int ldq, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sggsvd3")]
            internal static extern int Sggsvd3(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int n, int p, int* k, int* l, float* a, int lda, float* b, int ldb, float* alpha, float* beta, float* u, int ldu, float* v, int ldv, float* q, int ldq, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sggsvd3_work")]
            internal static extern int Sggsvd3Work(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int n, int p, int* k, int* l, float* a, int lda, float* b, int ldb, float* alpha, float* beta, float* u, int ldu, float* v, int ldv, float* q, int ldq, float* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sggsvd_work")]
            internal static extern int SggsvdWork(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int n, int p, int* k, int* l, float* a, int lda, float* b, int ldb, float* alpha, float* beta, float* u, int ldu, float* v, int ldv, float* q, int ldq, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sggsvp")]
            internal static extern int Sggsvp(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, float* a, int lda, float* b, int ldb, float tola, float tolb, int* k, int* l, float* u, int ldu, float* v, int ldv, float* q, int ldq);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sggsvp3")]
            internal static extern int Sggsvp3(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, float* a, int lda, float* b, int ldb, float tola, float tolb, int* k, int* l, float* u, int ldu, float* v, int ldv, float* q, int ldq);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sggsvp3_work")]
            internal static extern int Sggsvp3Work(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, float* a, int lda, float* b, int ldb, float tola, float tolb, int* k, int* l, float* u, int ldu, float* v, int ldv, float* q, int ldq, int* iwork, float* tau, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sggsvp_work")]
            internal static extern int SggsvpWork(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, float* a, int lda, float* b, int ldb, float tola, float tolb, int* k, int* l, float* u, int ldu, float* v, int ldv, float* q, int ldq, int* iwork, float* tau, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgtcon")]
            internal static extern int Sgtcon(sbyte norm, int n, float* dl, float* d, float* du, float* du2, int* ipiv, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgtcon_work")]
            internal static extern int SgtconWork(sbyte norm, int n, float* dl, float* d, float* du, float* du2, int* ipiv, float anorm, float* rcond, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgtrfs")]
            internal static extern int Sgtrfs(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int nrhs, float* dl, float* d, float* du, float* dlf, float* df, float* duf, float* du2, int* ipiv, float* b, int ldb, float* x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgtrfs_work")]
            internal static extern int SgtrfsWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int nrhs, float* dl, float* d, float* du, float* dlf, float* df, float* duf, float* du2, int* ipiv, float* b, int ldb, float* x, int ldx, float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgtsv")]
            internal static extern int Sgtsv(BLAS.LAYOUT matrixLayout, int n, int nrhs, float* dl, float* d, float* du, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgtsv_work")]
            internal static extern int SgtsvWork(BLAS.LAYOUT matrixLayout, int n, int nrhs, float* dl, float* d, float* du, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgtsvx")]
            internal static extern int Sgtsvx(BLAS.LAYOUT matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int nrhs, float* dl, float* d, float* du, float* dlf, float* df, float* duf, float* du2, int* ipiv, float* b, int ldb, float* x, int ldx, float* rcond, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgtsvx_work")]
            internal static extern int SgtsvxWork(BLAS.LAYOUT matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int nrhs, float* dl, float* d, float* du, float* dlf, float* df, float* duf, float* du2, int* ipiv, float* b, int ldb, float* x, int ldx, float* rcond, float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgttrf")]
            internal static extern int Sgttrf(int n, float* dl, float* d, float* du, float* du2, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgttrf_work")]
            internal static extern int SgttrfWork(int n, float* dl, float* d, float* du, float* du2, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgttrs")]
            internal static extern int Sgttrs(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int nrhs, float* dl, float* d, float* du, float* du2, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgttrs_work")]
            internal static extern int SgttrsWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int nrhs, float* dl, float* d, float* du, float* du2, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_shgeqz")]
            internal static extern int Shgeqz(BLAS.LAYOUT matrixLayout, sbyte job, sbyte compq, sbyte compz, int n, int ilo, int ihi, float* h, int ldh, float* t, int ldt, float* alphar, float* alphai, float* beta, float* q, int ldq, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_shgeqz_work")]
            internal static extern int ShgeqzWork(BLAS.LAYOUT matrixLayout, sbyte job, sbyte compq, sbyte compz, int n, int ilo, int ihi, float* h, int ldh, float* t, int ldt, float* alphar, float* alphai, float* beta, float* q, int ldq, float* z, int ldz, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_shsein")]
            internal static extern int Shsein(BLAS.LAYOUT matrixLayout, sbyte job, sbyte eigsrc, sbyte initv, int* select, int n, float* h, int ldh, float* wr, float* wi, float* vl, int ldvl, float* vr, int ldvr, int mm, int* m, int* ifaill, int* ifailr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_shsein_work")]
            internal static extern int ShseinWork(BLAS.LAYOUT matrixLayout, sbyte job, sbyte eigsrc, sbyte initv, int* select, int n, float* h, int ldh, float* wr, float* wi, float* vl, int ldvl, float* vr, int ldvr, int mm, int* m, float* work, int* ifaill, int* ifailr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_shseqr")]
            internal static extern int Shseqr(BLAS.LAYOUT matrixLayout, sbyte job, sbyte compz, int n, int ilo, int ihi, float* h, int ldh, float* wr, float* wi, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_shseqr_work")]
            internal static extern int ShseqrWork(BLAS.LAYOUT matrixLayout, sbyte job, sbyte compz, int n, int ilo, int ihi, float* h, int ldh, float* wr, float* wi, float* z, int ldz, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_slacn2")]
            internal static extern int Slacn2(int n, float* v, float* x, int* isgn, float* est, int* kase, int* isave);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_slacn2_work")]
            internal static extern int Slacn2Work(int n, float* v, float* x, int* isgn, float* est, int* kase, int* isave);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_slacpy")]
            internal static extern int Slacpy(BLAS.LAYOUT matrixLayout, sbyte uplo, int m, int n, float* a, int lda, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_slacpy_work")]
            internal static extern int SlacpyWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int m, int n, float* a, int lda, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_slag2d")]
            internal static extern int Slag2d(BLAS.LAYOUT matrixLayout, int m, int n, float* sa, int ldsa, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_slag2d_work")]
            internal static extern int Slag2dWork(BLAS.LAYOUT matrixLayout, int m, int n, float* sa, int ldsa, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_slagge")]
            internal static extern int Slagge(BLAS.LAYOUT matrixLayout, int m, int n, int kl, int ku, float* d, float* a, int lda, int* iseed);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_slagge_work")]
            internal static extern int SlaggeWork(BLAS.LAYOUT matrixLayout, int m, int n, int kl, int ku, float* d, float* a, int lda, int* iseed, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_slagsy")]
            internal static extern int Slagsy(BLAS.LAYOUT matrixLayout, int n, int k, float* d, float* a, int lda, int* iseed);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_slagsy_work")]
            internal static extern int SlagsyWork(BLAS.LAYOUT matrixLayout, int n, int k, float* d, float* a, int lda, int* iseed, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_slapmr")]
            internal static extern int Slapmr(BLAS.LAYOUT matrixLayout, int forwrd, int m, int n, float* x, int ldx, int* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_slapmr_work")]
            internal static extern int SlapmrWork(BLAS.LAYOUT matrixLayout, int forwrd, int m, int n, float* x, int ldx, int* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_slapmt")]
            internal static extern int Slapmt(BLAS.LAYOUT matrixLayout, int forwrd, int m, int n, float* x, int ldx, int* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_slapmt_work")]
            internal static extern int SlapmtWork(BLAS.LAYOUT matrixLayout, int forwrd, int m, int n, float* x, int ldx, int* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_slarfb")]
            internal static extern int Slarfb(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, sbyte direct, sbyte storev, int m, int n, int k, float* v, int ldv, float* t, int ldt, float* c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_slarfb_work")]
            internal static extern int SlarfbWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, sbyte direct, sbyte storev, int m, int n, int k, float* v, int ldv, float* t, int ldt, float* c, int ldc, float* work, int ldwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_slarfg")]
            internal static extern int Slarfg(int n, float* alpha, float* x, int incx, float* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_slarfg_work")]
            internal static extern int SlarfgWork(int n, float* alpha, float* x, int incx, float* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_slarft")]
            internal static extern int Slarft(BLAS.LAYOUT matrixLayout, sbyte direct, sbyte storev, int n, int k, float* v, int ldv, float* tau, float* t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_slarft_work")]
            internal static extern int SlarftWork(BLAS.LAYOUT matrixLayout, sbyte direct, sbyte storev, int n, int k, float* v, int ldv, float* tau, float* t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_slarfx")]
            internal static extern int Slarfx(BLAS.LAYOUT matrixLayout, sbyte side, int m, int n, float* v, float tau, float* c, int ldc, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_slarfx_work")]
            internal static extern int SlarfxWork(BLAS.LAYOUT matrixLayout, sbyte side, int m, int n, float* v, float tau, float* c, int ldc, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_slarnv")]
            internal static extern int Slarnv(int idist, int* iseed, int n, float* x);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_slarnv_work")]
            internal static extern int SlarnvWork(int idist, int* iseed, int n, float* x);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_slartgp")]
            internal static extern int Slartgp(float f, float g, float* cs, float* sn, float* r);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_slartgp_work")]
            internal static extern int SlartgpWork(float f, float g, float* cs, float* sn, float* r);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_slartgs")]
            internal static extern int Slartgs(float x, float y, float sigma, float* cs, float* sn);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_slartgs_work")]
            internal static extern int SlartgsWork(float x, float y, float sigma, float* cs, float* sn);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_slascl")]
            internal static extern int Slascl(BLAS.LAYOUT matrixLayout, sbyte type, int kl, int ku, float cfrom, float cto, int m, int n, float* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_slascl_work")]
            internal static extern int SlasclWork(BLAS.LAYOUT matrixLayout, sbyte type, int kl, int ku, float cfrom, float cto, int m, int n, float* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_slaset")]
            internal static extern int Slaset(BLAS.LAYOUT matrixLayout, sbyte uplo, int m, int n, float alpha, float beta, float* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_slaset_work")]
            internal static extern int SlasetWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int m, int n, float alpha, float beta, float* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_slasrt")]
            internal static extern int Slasrt(sbyte id, int n, float* d);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_slasrt_work")]
            internal static extern int SlasrtWork(sbyte id, int n, float* d);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_slaswp")]
            internal static extern int Slaswp(BLAS.LAYOUT matrixLayout, int n, float* a, int lda, int k1, int k2, int* ipiv, int incx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_slaswp_work")]
            internal static extern int SlaswpWork(BLAS.LAYOUT matrixLayout, int n, float* a, int lda, int k1, int k2, int* ipiv, int incx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_slatms")]
            internal static extern int Slatms(BLAS.LAYOUT matrixLayout, int m, int n, sbyte dist, int* iseed, sbyte sym, float* d, int mode, float cond, float dmax, int kl, int ku, sbyte pack, float* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_slatms_work")]
            internal static extern int SlatmsWork(BLAS.LAYOUT matrixLayout, int m, int n, sbyte dist, int* iseed, sbyte sym, float* d, int mode, float cond, float dmax, int kl, int ku, sbyte pack, float* a, int lda, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_slauum")]
            internal static extern int Slauum(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_slauum_work")]
            internal static extern int SlauumWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sopgtr")]
            internal static extern int Sopgtr(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* ap, float* tau, float* q, int ldq);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sopgtr_work")]
            internal static extern int SopgtrWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* ap, float* tau, float* q, int ldq, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sopmtr")]
            internal static extern int Sopmtr(BLAS.LAYOUT matrixLayout, sbyte side, sbyte uplo, BLAS.TRANS trans, int m, int n, float* ap, float* tau, float* c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sopmtr_work")]
            internal static extern int SopmtrWork(BLAS.LAYOUT matrixLayout, sbyte side, sbyte uplo, BLAS.TRANS trans, int m, int n, float* ap, float* tau, float* c, int ldc, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sorbdb")]
            internal static extern int Sorbdb(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, sbyte signs, int m, int p, int q, float* x11, int ldx11, float* x12, int ldx12, float* x21, int ldx21, float* x22, int ldx22, float* theta, float* phi, float* taup1, float* taup2, float* tauq1, float* tauq2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sorbdb_work")]
            internal static extern int SorbdbWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, sbyte signs, int m, int p, int q, float* x11, int ldx11, float* x12, int ldx12, float* x21, int ldx21, float* x22, int ldx22, float* theta, float* phi, float* taup1, float* taup2, float* tauq1, float* tauq2, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sorcsd")]
            internal static extern int Sorcsd(BLAS.LAYOUT matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, sbyte jobv2t, BLAS.TRANS trans, sbyte signs, int m, int p, int q, float* x11, int ldx11, float* x12, int ldx12, float* x21, int ldx21, float* x22, int ldx22, float* theta, float* u1, int ldu1, float* u2, int ldu2, float* v1t, int ldv1t, float* v2t, int ldv2t);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sorcsd2by1")]
            internal static extern int Sorcsd2by1(BLAS.LAYOUT matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, int m, int p, int q, float* x11, int ldx11, float* x21, int ldx21, float* theta, float* u1, int ldu1, float* u2, int ldu2, float* v1t, int ldv1t);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sorcsd2by1_work")]
            internal static extern int Sorcsd2by1Work(BLAS.LAYOUT matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, int m, int p, int q, float* x11, int ldx11, float* x21, int ldx21, float* theta, float* u1, int ldu1, float* u2, int ldu2, float* v1t, int ldv1t, float* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sorcsd_work")]
            internal static extern int SorcsdWork(BLAS.LAYOUT matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, sbyte jobv2t, BLAS.TRANS trans, sbyte signs, int m, int p, int q, float* x11, int ldx11, float* x12, int ldx12, float* x21, int ldx21, float* x22, int ldx22, float* theta, float* u1, int ldu1, float* u2, int ldu2, float* v1t, int ldv1t, float* v2t, int ldv2t, float* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sorgbr")]
            internal static extern int Sorgbr(BLAS.LAYOUT matrixLayout, sbyte vect, int m, int n, int k, float* a, int lda, float* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sorgbr_work")]
            internal static extern int SorgbrWork(BLAS.LAYOUT matrixLayout, sbyte vect, int m, int n, int k, float* a, int lda, float* tau, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sorghr")]
            internal static extern int Sorghr(BLAS.LAYOUT matrixLayout, int n, int ilo, int ihi, float* a, int lda, float* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sorghr_work")]
            internal static extern int SorghrWork(BLAS.LAYOUT matrixLayout, int n, int ilo, int ihi, float* a, int lda, float* tau, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sorglq")]
            internal static extern int Sorglq(BLAS.LAYOUT matrixLayout, int m, int n, int k, float* a, int lda, float* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sorglq_work")]
            internal static extern int SorglqWork(BLAS.LAYOUT matrixLayout, int m, int n, int k, float* a, int lda, float* tau, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sorgql")]
            internal static extern int Sorgql(BLAS.LAYOUT matrixLayout, int m, int n, int k, float* a, int lda, float* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sorgql_work")]
            internal static extern int SorgqlWork(BLAS.LAYOUT matrixLayout, int m, int n, int k, float* a, int lda, float* tau, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sorgqr")]
            internal static extern int Sorgqr(BLAS.LAYOUT matrixLayout, int m, int n, int k, float* a, int lda, float* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sorgqr_work")]
            internal static extern int SorgqrWork(BLAS.LAYOUT matrixLayout, int m, int n, int k, float* a, int lda, float* tau, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sorgrq")]
            internal static extern int Sorgrq(BLAS.LAYOUT matrixLayout, int m, int n, int k, float* a, int lda, float* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sorgrq_work")]
            internal static extern int SorgrqWork(BLAS.LAYOUT matrixLayout, int m, int n, int k, float* a, int lda, float* tau, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sorgtr")]
            internal static extern int Sorgtr(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda, float* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sorgtr_work")]
            internal static extern int SorgtrWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda, float* tau, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sormbr")]
            internal static extern int Sormbr(BLAS.LAYOUT matrixLayout, sbyte vect, sbyte side, BLAS.TRANS trans, int m, int n, int k, float* a, int lda, float* tau, float* c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sormbr_work")]
            internal static extern int SormbrWork(BLAS.LAYOUT matrixLayout, sbyte vect, sbyte side, BLAS.TRANS trans, int m, int n, int k, float* a, int lda, float* tau, float* c, int ldc, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sormhr")]
            internal static extern int Sormhr(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int ilo, int ihi, float* a, int lda, float* tau, float* c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sormhr_work")]
            internal static extern int SormhrWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int ilo, int ihi, float* a, int lda, float* tau, float* c, int ldc, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sormlq")]
            internal static extern int Sormlq(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, float* a, int lda, float* tau, float* c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sormlq_work")]
            internal static extern int SormlqWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, float* a, int lda, float* tau, float* c, int ldc, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sormql")]
            internal static extern int Sormql(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, float* a, int lda, float* tau, float* c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sormql_work")]
            internal static extern int SormqlWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, float* a, int lda, float* tau, float* c, int ldc, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sormqr")]
            internal static extern int Sormqr(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, float* a, int lda, float* tau, float* c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sormqr_work")]
            internal static extern int SormqrWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, float* a, int lda, float* tau, float* c, int ldc, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sormrq")]
            internal static extern int Sormrq(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, float* a, int lda, float* tau, float* c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sormrq_work")]
            internal static extern int SormrqWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, float* a, int lda, float* tau, float* c, int ldc, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sormrz")]
            internal static extern int Sormrz(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, int l, float* a, int lda, float* tau, float* c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sormrz_work")]
            internal static extern int SormrzWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, int l, float* a, int lda, float* tau, float* c, int ldc, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sormtr")]
            internal static extern int Sormtr(BLAS.LAYOUT matrixLayout, sbyte side, sbyte uplo, BLAS.TRANS trans, int m, int n, float* a, int lda, float* tau, float* c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sormtr_work")]
            internal static extern int SormtrWork(BLAS.LAYOUT matrixLayout, sbyte side, sbyte uplo, BLAS.TRANS trans, int m, int n, float* a, int lda, float* tau, float* c, int ldc, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_spbcon")]
            internal static extern int Spbcon(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, float* ab, int ldab, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_spbcon_work")]
            internal static extern int SpbconWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, float* ab, int ldab, float anorm, float* rcond, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_spbequ")]
            internal static extern int Spbequ(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, float* ab, int ldab, float* s, float* scond, float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_spbequ_work")]
            internal static extern int SpbequWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, float* ab, int ldab, float* s, float* scond, float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_spbrfs")]
            internal static extern int Spbrfs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, int nrhs, float* ab, int ldab, float* afb, int ldafb, float* b, int ldb, float* x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_spbrfs_work")]
            internal static extern int SpbrfsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, int nrhs, float* ab, int ldab, float* afb, int ldafb, float* b, int ldb, float* x, int ldx, float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_spbstf")]
            internal static extern int Spbstf(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kb, float* bb, int ldbb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_spbstf_work")]
            internal static extern int SpbstfWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kb, float* bb, int ldbb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_spbsv")]
            internal static extern int Spbsv(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, int nrhs, float* ab, int ldab, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_spbsv_work")]
            internal static extern int SpbsvWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, int nrhs, float* ab, int ldab, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_spbsvx")]
            internal static extern int Spbsvx(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int kd, int nrhs, float* ab, int ldab, float* afb, int ldafb, sbyte* equed, float* s, float* b, int ldb, float* x, int ldx, float* rcond, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_spbsvx_work")]
            internal static extern int SpbsvxWork(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int kd, int nrhs, float* ab, int ldab, float* afb, int ldafb, sbyte* equed, float* s, float* b, int ldb, float* x, int ldx, float* rcond, float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_spbtrf")]
            internal static extern int Spbtrf(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, float* ab, int ldab);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_spbtrf_work")]
            internal static extern int SpbtrfWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, float* ab, int ldab);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_spbtrs")]
            internal static extern int Spbtrs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, int nrhs, float* ab, int ldab, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_spbtrs_work")]
            internal static extern int SpbtrsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, int nrhs, float* ab, int ldab, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_spftrf")]
            internal static extern int Spftrf(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, float* a);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_spftrf_work")]
            internal static extern int SpftrfWork(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, float* a);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_spftri")]
            internal static extern int Spftri(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, float* a);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_spftri_work")]
            internal static extern int SpftriWork(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, float* a);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_spftrs")]
            internal static extern int Spftrs(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, int nrhs, float* a, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_spftrs_work")]
            internal static extern int SpftrsWork(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, int nrhs, float* a, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_spocon")]
            internal static extern int Spocon(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_spocon_work")]
            internal static extern int SpoconWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda, float anorm, float* rcond, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_spoequ")]
            internal static extern int Spoequ(BLAS.LAYOUT matrixLayout, int n, float* a, int lda, float* s, float* scond, float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_spoequ_work")]
            internal static extern int SpoequWork(BLAS.LAYOUT matrixLayout, int n, float* a, int lda, float* s, float* scond, float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_spoequb")]
            internal static extern int Spoequb(BLAS.LAYOUT matrixLayout, int n, float* a, int lda, float* s, float* scond, float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_spoequb_work")]
            internal static extern int SpoequbWork(BLAS.LAYOUT matrixLayout, int n, float* a, int lda, float* s, float* scond, float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sporfs")]
            internal static extern int Sporfs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, float* af, int ldaf, float* b, int ldb, float* x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sporfs_work")]
            internal static extern int SporfsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, float* af, int ldaf, float* b, int ldb, float* x, int ldx, float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sporfsx")]
            internal static extern int Sporfsx(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte equed, int n, int nrhs, float* a, int lda, float* af, int ldaf, float* s, float* b, int ldb, float* x, int ldx, float* rcond, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sporfsx_work")]
            internal static extern int SporfsxWork(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte equed, int n, int nrhs, float* a, int lda, float* af, int ldaf, float* s, float* b, int ldb, float* x, int ldx, float* rcond, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sposv")]
            internal static extern int Sposv(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sposv_work")]
            internal static extern int SposvWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sposvx")]
            internal static extern int Sposvx(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, float* a, int lda, float* af, int ldaf, sbyte* equed, float* s, float* b, int ldb, float* x, int ldx, float* rcond, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sposvx_work")]
            internal static extern int SposvxWork(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, float* a, int lda, float* af, int ldaf, sbyte* equed, float* s, float* b, int ldb, float* x, int ldx, float* rcond, float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sposvxx")]
            internal static extern int Sposvxx(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, float* a, int lda, float* af, int ldaf, sbyte* equed, float* s, float* b, int ldb, float* x, int ldx, float* rcond, float* rpvgrw, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sposvxx_work")]
            internal static extern int SposvxxWork(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, float* a, int lda, float* af, int ldaf, sbyte* equed, float* s, float* b, int ldb, float* x, int ldx, float* rcond, float* rpvgrw, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_spotrf")]
            internal static extern int Spotrf(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_spotrf2")]
            internal static extern int Spotrf2(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_spotrf2_work")]
            internal static extern int Spotrf2Work(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_spotrf_work")]
            internal static extern int SpotrfWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_spotri")]
            internal static extern int Spotri(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_spotri_work")]
            internal static extern int SpotriWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_spotrs")]
            internal static extern int Spotrs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_spotrs_work")]
            internal static extern int SpotrsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sppcon")]
            internal static extern int Sppcon(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* ap, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sppcon_work")]
            internal static extern int SppconWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* ap, float anorm, float* rcond, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sppequ")]
            internal static extern int Sppequ(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* ap, float* s, float* scond, float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sppequ_work")]
            internal static extern int SppequWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* ap, float* s, float* scond, float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_spprfs")]
            internal static extern int Spprfs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* ap, float* afp, float* b, int ldb, float* x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_spprfs_work")]
            internal static extern int SpprfsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* ap, float* afp, float* b, int ldb, float* x, int ldx, float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sppsv")]
            internal static extern int Sppsv(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* ap, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sppsv_work")]
            internal static extern int SppsvWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* ap, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sppsvx")]
            internal static extern int Sppsvx(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, float* ap, float* afp, sbyte* equed, float* s, float* b, int ldb, float* x, int ldx, float* rcond, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sppsvx_work")]
            internal static extern int SppsvxWork(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, float* ap, float* afp, sbyte* equed, float* s, float* b, int ldb, float* x, int ldx, float* rcond, float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_spptrf")]
            internal static extern int Spptrf(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_spptrf_work")]
            internal static extern int SpptrfWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_spptri")]
            internal static extern int Spptri(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_spptri_work")]
            internal static extern int SpptriWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_spptrs")]
            internal static extern int Spptrs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* ap, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_spptrs_work")]
            internal static extern int SpptrsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* ap, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_spstrf")]
            internal static extern int Spstrf(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda, int* piv, int* rank, float tol);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_spstrf_work")]
            internal static extern int SpstrfWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda, int* piv, int* rank, float tol, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sptcon")]
            internal static extern int Sptcon(int n, float* d, float* e, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sptcon_work")]
            internal static extern int SptconWork(int n, float* d, float* e, float anorm, float* rcond, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_spteqr")]
            internal static extern int Spteqr(BLAS.LAYOUT matrixLayout, sbyte compz, int n, float* d, float* e, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_spteqr_work")]
            internal static extern int SpteqrWork(BLAS.LAYOUT matrixLayout, sbyte compz, int n, float* d, float* e, float* z, int ldz, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sptrfs")]
            internal static extern int Sptrfs(BLAS.LAYOUT matrixLayout, int n, int nrhs, float* d, float* e, float* df, float* ef, float* b, int ldb, float* x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sptrfs_work")]
            internal static extern int SptrfsWork(BLAS.LAYOUT matrixLayout, int n, int nrhs, float* d, float* e, float* df, float* ef, float* b, int ldb, float* x, int ldx, float* ferr, float* berr, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sptsv")]
            internal static extern int Sptsv(BLAS.LAYOUT matrixLayout, int n, int nrhs, float* d, float* e, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sptsv_work")]
            internal static extern int SptsvWork(BLAS.LAYOUT matrixLayout, int n, int nrhs, float* d, float* e, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sptsvx")]
            internal static extern int Sptsvx(BLAS.LAYOUT matrixLayout, sbyte fact, int n, int nrhs, float* d, float* e, float* df, float* ef, float* b, int ldb, float* x, int ldx, float* rcond, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sptsvx_work")]
            internal static extern int SptsvxWork(BLAS.LAYOUT matrixLayout, sbyte fact, int n, int nrhs, float* d, float* e, float* df, float* ef, float* b, int ldb, float* x, int ldx, float* rcond, float* ferr, float* berr, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_spttrf")]
            internal static extern int Spttrf(int n, float* d, float* e);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_spttrf_work")]
            internal static extern int SpttrfWork(int n, float* d, float* e);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_spttrs")]
            internal static extern int Spttrs(BLAS.LAYOUT matrixLayout, int n, int nrhs, float* d, float* e, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_spttrs_work")]
            internal static extern int SpttrsWork(BLAS.LAYOUT matrixLayout, int n, int nrhs, float* d, float* e, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssbev")]
            internal static extern int Ssbev(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, float* ab, int ldab, float* w, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssbev_work")]
            internal static extern int SsbevWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, float* ab, int ldab, float* w, float* z, int ldz, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssbevd")]
            internal static extern int Ssbevd(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, float* ab, int ldab, float* w, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssbevd_work")]
            internal static extern int SsbevdWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, float* ab, int ldab, float* w, float* z, int ldz, float* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssbevx")]
            internal static extern int Ssbevx(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, int kd, float* ab, int ldab, float* q, int ldq, float vl, float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssbevx_work")]
            internal static extern int SsbevxWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, int kd, float* ab, int ldab, float* q, int ldq, float vl, float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, float* work, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssbgst")]
            internal static extern int Ssbgst(BLAS.LAYOUT matrixLayout, sbyte vect, sbyte uplo, int n, int ka, int kb, float* ab, int ldab, float* bb, int ldbb, float* x, int ldx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssbgst_work")]
            internal static extern int SsbgstWork(BLAS.LAYOUT matrixLayout, sbyte vect, sbyte uplo, int n, int ka, int kb, float* ab, int ldab, float* bb, int ldbb, float* x, int ldx, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssbgv")]
            internal static extern int Ssbgv(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int ka, int kb, float* ab, int ldab, float* bb, int ldbb, float* w, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssbgv_work")]
            internal static extern int SsbgvWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int ka, int kb, float* ab, int ldab, float* bb, int ldbb, float* w, float* z, int ldz, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssbgvd")]
            internal static extern int Ssbgvd(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int ka, int kb, float* ab, int ldab, float* bb, int ldbb, float* w, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssbgvd_work")]
            internal static extern int SsbgvdWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int ka, int kb, float* ab, int ldab, float* bb, int ldbb, float* w, float* z, int ldz, float* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssbgvx")]
            internal static extern int Ssbgvx(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, int ka, int kb, float* ab, int ldab, float* bb, int ldbb, float* q, int ldq, float vl, float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssbgvx_work")]
            internal static extern int SsbgvxWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, int ka, int kb, float* ab, int ldab, float* bb, int ldbb, float* q, int ldq, float vl, float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, float* work, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssbtrd")]
            internal static extern int Ssbtrd(BLAS.LAYOUT matrixLayout, sbyte vect, sbyte uplo, int n, int kd, float* ab, int ldab, float* d, float* e, float* q, int ldq);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssbtrd_work")]
            internal static extern int SsbtrdWork(BLAS.LAYOUT matrixLayout, sbyte vect, sbyte uplo, int n, int kd, float* ab, int ldab, float* d, float* e, float* q, int ldq, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssfrk")]
            internal static extern int Ssfrk(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, BLAS.TRANS trans, int n, int k, float alpha, float* a, int lda, float beta, float* c);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssfrk_work")]
            internal static extern int SsfrkWork(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, BLAS.TRANS trans, int n, int k, float alpha, float* a, int lda, float beta, float* c);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sspcon")]
            internal static extern int Sspcon(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* ap, int* ipiv, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sspcon_work")]
            internal static extern int SspconWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* ap, int* ipiv, float anorm, float* rcond, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sspev")]
            internal static extern int Sspev(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, float* ap, float* w, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sspev_work")]
            internal static extern int SspevWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, float* ap, float* w, float* z, int ldz, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sspevd")]
            internal static extern int Sspevd(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, float* ap, float* w, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sspevd_work")]
            internal static extern int SspevdWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, float* ap, float* w, float* z, int ldz, float* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sspevx")]
            internal static extern int Sspevx(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, float* ap, float vl, float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sspevx_work")]
            internal static extern int SspevxWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, float* ap, float vl, float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, float* work, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sspgst")]
            internal static extern int Sspgst(BLAS.LAYOUT matrixLayout, int itype, sbyte uplo, int n, float* ap, float* bp);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sspgst_work")]
            internal static extern int SspgstWork(BLAS.LAYOUT matrixLayout, int itype, sbyte uplo, int n, float* ap, float* bp);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sspgv")]
            internal static extern int Sspgv(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, float* ap, float* bp, float* w, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sspgv_work")]
            internal static extern int SspgvWork(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, float* ap, float* bp, float* w, float* z, int ldz, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sspgvd")]
            internal static extern int Sspgvd(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, float* ap, float* bp, float* w, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sspgvd_work")]
            internal static extern int SspgvdWork(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, float* ap, float* bp, float* w, float* z, int ldz, float* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sspgvx")]
            internal static extern int Sspgvx(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte range, sbyte uplo, int n, float* ap, float* bp, float vl, float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sspgvx_work")]
            internal static extern int SspgvxWork(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte range, sbyte uplo, int n, float* ap, float* bp, float vl, float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, float* work, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssprfs")]
            internal static extern int Ssprfs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* ap, float* afp, int* ipiv, float* b, int ldb, float* x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssprfs_work")]
            internal static extern int SsprfsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* ap, float* afp, int* ipiv, float* b, int ldb, float* x, int ldx, float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sspsv")]
            internal static extern int Sspsv(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* ap, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sspsv_work")]
            internal static extern int SspsvWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* ap, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sspsvx")]
            internal static extern int Sspsvx(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, float* ap, float* afp, int* ipiv, float* b, int ldb, float* x, int ldx, float* rcond, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sspsvx_work")]
            internal static extern int SspsvxWork(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, float* ap, float* afp, int* ipiv, float* b, int ldb, float* x, int ldx, float* rcond, float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssptrd")]
            internal static extern int Ssptrd(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* ap, float* d, float* e, float* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssptrd_work")]
            internal static extern int SsptrdWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* ap, float* d, float* e, float* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssptrf")]
            internal static extern int Ssptrf(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* ap, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssptrf_work")]
            internal static extern int SsptrfWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* ap, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssptri")]
            internal static extern int Ssptri(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* ap, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssptri_work")]
            internal static extern int SsptriWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* ap, int* ipiv, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssptrs")]
            internal static extern int Ssptrs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* ap, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssptrs_work")]
            internal static extern int SsptrsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* ap, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sstebz")]
            internal static extern int Sstebz(sbyte range, sbyte order, int n, float vl, float vu, int il, int iu, float abstol, float* d, float* e, int* m, int* nsplit, float* w, int* iblock, int* isplit);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sstebz_work")]
            internal static extern int SstebzWork(sbyte range, sbyte order, int n, float vl, float vu, int il, int iu, float abstol, float* d, float* e, int* m, int* nsplit, float* w, int* iblock, int* isplit, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sstedc")]
            internal static extern int Sstedc(BLAS.LAYOUT matrixLayout, sbyte compz, int n, float* d, float* e, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sstedc_work")]
            internal static extern int SstedcWork(BLAS.LAYOUT matrixLayout, sbyte compz, int n, float* d, float* e, float* z, int ldz, float* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sstegr")]
            internal static extern int Sstegr(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, int n, float* d, float* e, float vl, float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, int* isuppz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sstegr_work")]
            internal static extern int SstegrWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, int n, float* d, float* e, float vl, float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, int* isuppz, float* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sstein")]
            internal static extern int Sstein(BLAS.LAYOUT matrixLayout, int n, float* d, float* e, int m, float* w, int* iblock, int* isplit, float* z, int ldz, int* ifailv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sstein_work")]
            internal static extern int SsteinWork(BLAS.LAYOUT matrixLayout, int n, float* d, float* e, int m, float* w, int* iblock, int* isplit, float* z, int ldz, float* work, int* iwork, int* ifailv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sstemr")]
            internal static extern int Sstemr(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, int n, float* d, float* e, float vl, float vu, int il, int iu, int* m, float* w, float* z, int ldz, int nzc, int* isuppz, int* tryrac);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sstemr_work")]
            internal static extern int SstemrWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, int n, float* d, float* e, float vl, float vu, int il, int iu, int* m, float* w, float* z, int ldz, int nzc, int* isuppz, int* tryrac, float* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssteqr")]
            internal static extern int Ssteqr(BLAS.LAYOUT matrixLayout, sbyte compz, int n, float* d, float* e, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssteqr_work")]
            internal static extern int SsteqrWork(BLAS.LAYOUT matrixLayout, sbyte compz, int n, float* d, float* e, float* z, int ldz, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssterf")]
            internal static extern int Ssterf(int n, float* d, float* e);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssterf_work")]
            internal static extern int SsterfWork(int n, float* d, float* e);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sstev")]
            internal static extern int Sstev(BLAS.LAYOUT matrixLayout, sbyte jobz, int n, float* d, float* e, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sstev_work")]
            internal static extern int SstevWork(BLAS.LAYOUT matrixLayout, sbyte jobz, int n, float* d, float* e, float* z, int ldz, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sstevd")]
            internal static extern int Sstevd(BLAS.LAYOUT matrixLayout, sbyte jobz, int n, float* d, float* e, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sstevd_work")]
            internal static extern int SstevdWork(BLAS.LAYOUT matrixLayout, sbyte jobz, int n, float* d, float* e, float* z, int ldz, float* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sstevr")]
            internal static extern int Sstevr(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, int n, float* d, float* e, float vl, float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, int* isuppz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sstevr_work")]
            internal static extern int SstevrWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, int n, float* d, float* e, float vl, float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, int* isuppz, float* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sstevx")]
            internal static extern int Sstevx(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, int n, float* d, float* e, float vl, float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sstevx_work")]
            internal static extern int SstevxWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, int n, float* d, float* e, float vl, float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, float* work, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssycon")]
            internal static extern int Ssycon(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda, int* ipiv, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssycon_work")]
            internal static extern int SsyconWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda, int* ipiv, float anorm, float* rcond, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssyconv")]
            internal static extern int Ssyconv(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte way, int n, float* a, int lda, int* ipiv, float* e);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssyconv_work")]
            internal static extern int SsyconvWork(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte way, int n, float* a, int lda, int* ipiv, float* e);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssyequb")]
            internal static extern int Ssyequb(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda, float* s, float* scond, float* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssyequb_work")]
            internal static extern int SsyequbWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda, float* s, float* scond, float* amax, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssyev")]
            internal static extern int Ssyev(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, float* a, int lda, float* w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssyev_work")]
            internal static extern int SsyevWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, float* a, int lda, float* w, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssyevd")]
            internal static extern int Ssyevd(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, float* a, int lda, float* w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssyevd_work")]
            internal static extern int SsyevdWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, float* a, int lda, float* w, float* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssyevr")]
            internal static extern int Ssyevr(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, float* a, int lda, float vl, float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, int* isuppz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssyevr_work")]
            internal static extern int SsyevrWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, float* a, int lda, float vl, float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, int* isuppz, float* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssyevx")]
            internal static extern int Ssyevx(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, float* a, int lda, float vl, float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssyevx_work")]
            internal static extern int SsyevxWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, float* a, int lda, float vl, float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, float* work, int lwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssygst")]
            internal static extern int Ssygst(BLAS.LAYOUT matrixLayout, int itype, sbyte uplo, int n, float* a, int lda, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssygst_work")]
            internal static extern int SsygstWork(BLAS.LAYOUT matrixLayout, int itype, sbyte uplo, int n, float* a, int lda, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssygv")]
            internal static extern int Ssygv(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, float* a, int lda, float* b, int ldb, float* w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssygv_work")]
            internal static extern int SsygvWork(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, float* a, int lda, float* b, int ldb, float* w, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssygvd")]
            internal static extern int Ssygvd(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, float* a, int lda, float* b, int ldb, float* w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssygvd_work")]
            internal static extern int SsygvdWork(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, float* a, int lda, float* b, int ldb, float* w, float* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssygvx")]
            internal static extern int Ssygvx(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte range, sbyte uplo, int n, float* a, int lda, float* b, int ldb, float vl, float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssygvx_work")]
            internal static extern int SsygvxWork(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte range, sbyte uplo, int n, float* a, int lda, float* b, int ldb, float vl, float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, float* work, int lwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssyrfs")]
            internal static extern int Ssyrfs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, float* af, int ldaf, int* ipiv, float* b, int ldb, float* x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssyrfs_work")]
            internal static extern int SsyrfsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, float* af, int ldaf, int* ipiv, float* b, int ldb, float* x, int ldx, float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssyrfsx")]
            internal static extern int Ssyrfsx(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte equed, int n, int nrhs, float* a, int lda, float* af, int ldaf, int* ipiv, float* s, float* b, int ldb, float* x, int ldx, float* rcond, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssyrfsx_work")]
            internal static extern int SsyrfsxWork(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte equed, int n, int nrhs, float* a, int lda, float* af, int ldaf, int* ipiv, float* s, float* b, int ldb, float* x, int ldx, float* rcond, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssysv")]
            internal static extern int Ssysv(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssysv_rook")]
            internal static extern int SsysvRook(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssysv_rook_work")]
            internal static extern int SsysvRookWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssysv_work")]
            internal static extern int SsysvWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssysvx")]
            internal static extern int Ssysvx(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, float* a, int lda, float* af, int ldaf, int* ipiv, float* b, int ldb, float* x, int ldx, float* rcond, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssysvx_work")]
            internal static extern int SsysvxWork(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, float* a, int lda, float* af, int ldaf, int* ipiv, float* b, int ldb, float* x, int ldx, float* rcond, float* ferr, float* berr, float* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssysvxx")]
            internal static extern int Ssysvxx(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, float* a, int lda, float* af, int ldaf, int* ipiv, sbyte* equed, float* s, float* b, int ldb, float* x, int ldx, float* rcond, float* rpvgrw, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssysvxx_work")]
            internal static extern int SsysvxxWork(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, float* a, int lda, float* af, int ldaf, int* ipiv, sbyte* equed, float* s, float* b, int ldb, float* x, int ldx, float* rcond, float* rpvgrw, float* berr, int n_err_bnds, float* err_bnds_norm, float* err_bnds_comp, int nparams, float* @params, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssyswapr")]
            internal static extern int Ssyswapr(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda, int i1, int i2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssyswapr_work")]
            internal static extern int SsyswaprWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda, int i1, int i2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssytrd")]
            internal static extern int Ssytrd(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda, float* d, float* e, float* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssytrd_work")]
            internal static extern int SsytrdWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda, float* d, float* e, float* tau, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssytrf")]
            internal static extern int Ssytrf(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssytrf_rook")]
            internal static extern int SsytrfRook(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssytrf_rook_work")]
            internal static extern int SsytrfRookWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda, int* ipiv, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssytrf_work")]
            internal static extern int SsytrfWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda, int* ipiv, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssytri")]
            internal static extern int Ssytri(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssytri2")]
            internal static extern int Ssytri2(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssytri2_work")]
            internal static extern int Ssytri2Work(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda, int* ipiv, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssytri2x")]
            internal static extern int Ssytri2x(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda, int* ipiv, int nb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssytri2x_work")]
            internal static extern int Ssytri2xWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda, int* ipiv, float* work, int nb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssytri_work")]
            internal static extern int SsytriWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda, int* ipiv, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssytrs")]
            internal static extern int Ssytrs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssytrs2")]
            internal static extern int Ssytrs2(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssytrs2_work")]
            internal static extern int Ssytrs2Work(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssytrs_rook")]
            internal static extern int SsytrsRook(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssytrs_rook_work")]
            internal static extern int SsytrsRookWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssytrs_work")]
            internal static extern int SsytrsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_stbcon")]
            internal static extern int Stbcon(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int n, int kd, float* ab, int ldab, float* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_stbcon_work")]
            internal static extern int StbconWork(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int n, int kd, float* ab, int ldab, float* rcond, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_stbrfs")]
            internal static extern int Stbrfs(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int kd, int nrhs, float* ab, int ldab, float* b, int ldb, float* x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_stbrfs_work")]
            internal static extern int StbrfsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int kd, int nrhs, float* ab, int ldab, float* b, int ldb, float* x, int ldx, float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_stbtrs")]
            internal static extern int Stbtrs(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int kd, int nrhs, float* ab, int ldab, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_stbtrs_work")]
            internal static extern int StbtrsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int kd, int nrhs, float* ab, int ldab, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_stfsm")]
            internal static extern int Stfsm(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte side, sbyte uplo, BLAS.TRANS trans, sbyte diag, int m, int n, float alpha, float* a, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_stfsm_work")]
            internal static extern int StfsmWork(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte side, sbyte uplo, BLAS.TRANS trans, sbyte diag, int m, int n, float alpha, float* a, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_stftri")]
            internal static extern int Stftri(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, sbyte diag, int n, float* a);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_stftri_work")]
            internal static extern int StftriWork(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, sbyte diag, int n, float* a);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_stfttp")]
            internal static extern int Stfttp(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, float* arf, float* ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_stfttp_work")]
            internal static extern int StfttpWork(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, float* arf, float* ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_stfttr")]
            internal static extern int Stfttr(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, float* arf, float* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_stfttr_work")]
            internal static extern int StfttrWork(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, float* arf, float* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_stgevc")]
            internal static extern int Stgevc(BLAS.LAYOUT matrixLayout, sbyte side, sbyte howmny, int* select, int n, float* s, int lds, float* p, int ldp, float* vl, int ldvl, float* vr, int ldvr, int mm, int* m);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_stgevc_work")]
            internal static extern int StgevcWork(BLAS.LAYOUT matrixLayout, sbyte side, sbyte howmny, int* select, int n, float* s, int lds, float* p, int ldp, float* vl, int ldvl, float* vr, int ldvr, int mm, int* m, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_stgexc")]
            internal static extern int Stgexc(BLAS.LAYOUT matrixLayout, int wantq, int wantz, int n, float* a, int lda, float* b, int ldb, float* q, int ldq, float* z, int ldz, int* ifst, int* ilst);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_stgexc_work")]
            internal static extern int StgexcWork(BLAS.LAYOUT matrixLayout, int wantq, int wantz, int n, float* a, int lda, float* b, int ldb, float* q, int ldq, float* z, int ldz, int* ifst, int* ilst, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_stgsen")]
            internal static extern int Stgsen(BLAS.LAYOUT matrixLayout, int ijob, int wantq, int wantz, int* select, int n, float* a, int lda, float* b, int ldb, float* alphar, float* alphai, float* beta, float* q, int ldq, float* z, int ldz, int* m, float* pl, float* pr, float* dif);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_stgsen_work")]
            internal static extern int StgsenWork(BLAS.LAYOUT matrixLayout, int ijob, int wantq, int wantz, int* select, int n, float* a, int lda, float* b, int ldb, float* alphar, float* alphai, float* beta, float* q, int ldq, float* z, int ldz, int* m, float* pl, float* pr, float* dif, float* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_stgsja")]
            internal static extern int Stgsja(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, int k, int l, float* a, int lda, float* b, int ldb, float tola, float tolb, float* alpha, float* beta, float* u, int ldu, float* v, int ldv, float* q, int ldq, int* ncycle);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_stgsja_work")]
            internal static extern int StgsjaWork(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, int k, int l, float* a, int lda, float* b, int ldb, float tola, float tolb, float* alpha, float* beta, float* u, int ldu, float* v, int ldv, float* q, int ldq, float* work, int* ncycle);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_stgsna")]
            internal static extern int Stgsna(BLAS.LAYOUT matrixLayout, sbyte job, sbyte howmny, int* select, int n, float* a, int lda, float* b, int ldb, float* vl, int ldvl, float* vr, int ldvr, float* s, float* dif, int mm, int* m);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_stgsna_work")]
            internal static extern int StgsnaWork(BLAS.LAYOUT matrixLayout, sbyte job, sbyte howmny, int* select, int n, float* a, int lda, float* b, int ldb, float* vl, int ldvl, float* vr, int ldvr, float* s, float* dif, int mm, int* m, float* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_stgsyl")]
            internal static extern int Stgsyl(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int ijob, int m, int n, float* a, int lda, float* b, int ldb, float* c, int ldc, float* d, int ldd, float* e, int lde, float* f, int ldf, float* scale, float* dif);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_stgsyl_work")]
            internal static extern int StgsylWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int ijob, int m, int n, float* a, int lda, float* b, int ldb, float* c, int ldc, float* d, int ldd, float* e, int lde, float* f, int ldf, float* scale, float* dif, float* work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_stpcon")]
            internal static extern int Stpcon(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int n, float* ap, float* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_stpcon_work")]
            internal static extern int StpconWork(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int n, float* ap, float* rcond, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_stpmqrt")]
            internal static extern int Stpmqrt(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, int l, int nb, float* v, int ldv, float* t, int ldt, float* a, int lda, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_stpmqrt_work")]
            internal static extern int StpmqrtWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, int l, int nb, float* v, int ldv, float* t, int ldt, float* a, int lda, float* b, int ldb, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_stpqrt")]
            internal static extern int Stpqrt(BLAS.LAYOUT matrixLayout, int m, int n, int l, int nb, float* a, int lda, float* b, int ldb, float* t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_stpqrt2")]
            internal static extern int Stpqrt2(BLAS.LAYOUT matrixLayout, int m, int n, int l, float* a, int lda, float* b, int ldb, float* t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_stpqrt2_work")]
            internal static extern int Stpqrt2Work(BLAS.LAYOUT matrixLayout, int m, int n, int l, float* a, int lda, float* b, int ldb, float* t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_stpqrt_work")]
            internal static extern int StpqrtWork(BLAS.LAYOUT matrixLayout, int m, int n, int l, int nb, float* a, int lda, float* b, int ldb, float* t, int ldt, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_stprfb")]
            internal static extern int Stprfb(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, sbyte direct, sbyte storev, int m, int n, int k, int l, float* v, int ldv, float* t, int ldt, float* a, int lda, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_stprfb_work")]
            internal static extern int StprfbWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, sbyte direct, sbyte storev, int m, int n, int k, int l, float* v, int ldv, float* t, int ldt, float* a, int lda, float* b, int ldb, float* work, int ldwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_stprfs")]
            internal static extern int Stprfs(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, float* ap, float* b, int ldb, float* x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_stprfs_work")]
            internal static extern int StprfsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, float* ap, float* b, int ldb, float* x, int ldx, float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_stptri")]
            internal static extern int Stptri(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte diag, int n, float* ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_stptri_work")]
            internal static extern int StptriWork(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte diag, int n, float* ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_stptrs")]
            internal static extern int Stptrs(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, float* ap, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_stptrs_work")]
            internal static extern int StptrsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, float* ap, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_stpttf")]
            internal static extern int Stpttf(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, float* ap, float* arf);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_stpttf_work")]
            internal static extern int StpttfWork(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, float* ap, float* arf);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_stpttr")]
            internal static extern int Stpttr(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* ap, float* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_stpttr_work")]
            internal static extern int StpttrWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* ap, float* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_strcon")]
            internal static extern int Strcon(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int n, float* a, int lda, float* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_strcon_work")]
            internal static extern int StrconWork(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int n, float* a, int lda, float* rcond, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_strevc")]
            internal static extern int Strevc(BLAS.LAYOUT matrixLayout, sbyte side, sbyte howmny, int* select, int n, float* t, int ldt, float* vl, int ldvl, float* vr, int ldvr, int mm, int* m);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_strevc_work")]
            internal static extern int StrevcWork(BLAS.LAYOUT matrixLayout, sbyte side, sbyte howmny, int* select, int n, float* t, int ldt, float* vl, int ldvl, float* vr, int ldvr, int mm, int* m, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_strexc")]
            internal static extern int Strexc(BLAS.LAYOUT matrixLayout, sbyte compq, int n, float* t, int ldt, float* q, int ldq, int* ifst, int* ilst);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_strexc_work")]
            internal static extern int StrexcWork(BLAS.LAYOUT matrixLayout, sbyte compq, int n, float* t, int ldt, float* q, int ldq, int* ifst, int* ilst, float* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_strrfs")]
            internal static extern int Strrfs(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, float* a, int lda, float* b, int ldb, float* x, int ldx, float* ferr, float* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_strrfs_work")]
            internal static extern int StrrfsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, float* a, int lda, float* b, int ldb, float* x, int ldx, float* ferr, float* berr, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_strsen")]
            internal static extern int Strsen(BLAS.LAYOUT matrixLayout, sbyte job, sbyte compq, int* select, int n, float* t, int ldt, float* q, int ldq, float* wr, float* wi, int* m, float* s, float* sep);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_strsen_work")]
            internal static extern int StrsenWork(BLAS.LAYOUT matrixLayout, sbyte job, sbyte compq, int* select, int n, float* t, int ldt, float* q, int ldq, float* wr, float* wi, int* m, float* s, float* sep, float* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_strsna")]
            internal static extern int Strsna(BLAS.LAYOUT matrixLayout, sbyte job, sbyte howmny, int* select, int n, float* t, int ldt, float* vl, int ldvl, float* vr, int ldvr, float* s, float* sep, int mm, int* m);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_strsna_work")]
            internal static extern int StrsnaWork(BLAS.LAYOUT matrixLayout, sbyte job, sbyte howmny, int* select, int n, float* t, int ldt, float* vl, int ldvl, float* vr, int ldvr, float* s, float* sep, int mm, int* m, float* work, int ldwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_strsyl")]
            internal static extern int Strsyl(BLAS.LAYOUT matrixLayout, sbyte trana, sbyte tranb, int isgn, int m, int n, float* a, int lda, float* b, int ldb, float* c, int ldc, float* scale);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_strsyl_work")]
            internal static extern int StrsylWork(BLAS.LAYOUT matrixLayout, sbyte trana, sbyte tranb, int isgn, int m, int n, float* a, int lda, float* b, int ldb, float* c, int ldc, float* scale);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_strtri")]
            internal static extern int Strtri(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte diag, int n, float* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_strtri_work")]
            internal static extern int StrtriWork(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte diag, int n, float* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_strtrs")]
            internal static extern int Strtrs(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, float* a, int lda, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_strtrs_work")]
            internal static extern int StrtrsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, float* a, int lda, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_strttf")]
            internal static extern int Strttf(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, float* a, int lda, float* arf);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_strttf_work")]
            internal static extern int StrttfWork(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, float* a, int lda, float* arf);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_strttp")]
            internal static extern int Strttp(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda, float* ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_strttp_work")]
            internal static extern int StrttpWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda, float* ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_stzrzf")]
            internal static extern int Stzrzf(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda, float* tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_stzrzf_work")]
            internal static extern int StzrzfWork(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda, float* tau, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zbbcsd")]
            internal static extern int Zbbcsd(BLAS.LAYOUT matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, sbyte jobv2t, BLAS.TRANS trans, int m, int p, int q, double* theta, double* phi, System.IntPtr u1, int ldu1, System.IntPtr u2, int ldu2, System.IntPtr v1t, int ldv1t, System.IntPtr v2t, int ldv2t, double* b11d, double* b11e, double* b12d, double* b12e, double* b21d, double* b21e, double* b22d, double* b22e);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zbbcsd_work")]
            internal static extern int ZbbcsdWork(BLAS.LAYOUT matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, sbyte jobv2t, BLAS.TRANS trans, int m, int p, int q, double* theta, double* phi, System.IntPtr u1, int ldu1, System.IntPtr u2, int ldu2, System.IntPtr v1t, int ldv1t, System.IntPtr v2t, int ldv2t, double* b11d, double* b11e, double* b12d, double* b12e, double* b21d, double* b21e, double* b22d, double* b22e, double* rwork, int lrwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zbdsqr")]
            internal static extern int Zbdsqr(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int ncvt, int nru, int ncc, double* d, double* e, System.IntPtr vt, int ldvt, System.IntPtr u, int ldu, System.IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zbdsqr_work")]
            internal static extern int ZbdsqrWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int ncvt, int nru, int ncc, double* d, double* e, System.IntPtr vt, int ldvt, System.IntPtr u, int ldu, System.IntPtr c, int ldc, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zcgesv")]
            internal static extern int Zcgesv(BLAS.LAYOUT matrixLayout, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb, System.IntPtr x, int ldx, int* iter);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zcgesv_work")]
            internal static extern int ZcgesvWork(BLAS.LAYOUT matrixLayout, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb, System.IntPtr x, int ldx, System.IntPtr work, System.IntPtr swork, double* rwork, int* iter);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zcposv")]
            internal static extern int Zcposv(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr x, int ldx, int* iter);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zcposv_work")]
            internal static extern int ZcposvWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr x, int ldx, System.IntPtr work, System.IntPtr swork, double* rwork, int* iter);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgbbrd")]
            internal static extern int Zgbbrd(BLAS.LAYOUT matrixLayout, sbyte vect, int m, int n, int ncc, int kl, int ku, System.IntPtr ab, int ldab, double* d, double* e, System.IntPtr q, int ldq, System.IntPtr pt, int ldpt, System.IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgbbrd_work")]
            internal static extern int ZgbbrdWork(BLAS.LAYOUT matrixLayout, sbyte vect, int m, int n, int ncc, int kl, int ku, System.IntPtr ab, int ldab, double* d, double* e, System.IntPtr q, int ldq, System.IntPtr pt, int ldpt, System.IntPtr c, int ldc, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgbcon")]
            internal static extern int Zgbcon(BLAS.LAYOUT matrixLayout, sbyte norm, int n, int kl, int ku, System.IntPtr ab, int ldab, int* ipiv, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgbcon_work")]
            internal static extern int ZgbconWork(BLAS.LAYOUT matrixLayout, sbyte norm, int n, int kl, int ku, System.IntPtr ab, int ldab, int* ipiv, double anorm, double* rcond, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgbequ")]
            internal static extern int Zgbequ(BLAS.LAYOUT matrixLayout, int m, int n, int kl, int ku, System.IntPtr ab, int ldab, double* r, double* c, double* rowcnd, double* colcnd, double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgbequ_work")]
            internal static extern int ZgbequWork(BLAS.LAYOUT matrixLayout, int m, int n, int kl, int ku, System.IntPtr ab, int ldab, double* r, double* c, double* rowcnd, double* colcnd, double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgbequb")]
            internal static extern int Zgbequb(BLAS.LAYOUT matrixLayout, int m, int n, int kl, int ku, System.IntPtr ab, int ldab, double* r, double* c, double* rowcnd, double* colcnd, double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgbequb_work")]
            internal static extern int ZgbequbWork(BLAS.LAYOUT matrixLayout, int m, int n, int kl, int ku, System.IntPtr ab, int ldab, double* r, double* c, double* rowcnd, double* colcnd, double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgbrfs")]
            internal static extern int Zgbrfs(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, System.IntPtr ab, int ldab, System.IntPtr afb, int ldafb, int* ipiv, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgbrfs_work")]
            internal static extern int ZgbrfsWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, System.IntPtr ab, int ldab, System.IntPtr afb, int ldafb, int* ipiv, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* ferr, double* berr, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgbrfsx")]
            internal static extern int Zgbrfsx(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, sbyte equed, int n, int kl, int ku, int nrhs, System.IntPtr ab, int ldab, System.IntPtr afb, int ldafb, int* ipiv, double* r, double* c, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* rcond, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgbrfsx_work")]
            internal static extern int ZgbrfsxWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, sbyte equed, int n, int kl, int ku, int nrhs, System.IntPtr ab, int ldab, System.IntPtr afb, int ldafb, int* ipiv, double* r, double* c, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* rcond, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgbsv")]
            internal static extern int Zgbsv(BLAS.LAYOUT matrixLayout, int n, int kl, int ku, int nrhs, System.IntPtr ab, int ldab, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgbsv_work")]
            internal static extern int ZgbsvWork(BLAS.LAYOUT matrixLayout, int n, int kl, int ku, int nrhs, System.IntPtr ab, int ldab, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgbsvx")]
            internal static extern int Zgbsvx(BLAS.LAYOUT matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, System.IntPtr ab, int ldab, System.IntPtr afb, int ldafb, int* ipiv, sbyte* equed, double* r, double* c, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* rcond, double* ferr, double* berr, double* rpivot);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgbsvx_work")]
            internal static extern int ZgbsvxWork(BLAS.LAYOUT matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, System.IntPtr ab, int ldab, System.IntPtr afb, int ldafb, int* ipiv, sbyte* equed, double* r, double* c, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* rcond, double* ferr, double* berr, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgbsvxx")]
            internal static extern int Zgbsvxx(BLAS.LAYOUT matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, System.IntPtr ab, int ldab, System.IntPtr afb, int ldafb, int* ipiv, sbyte* equed, double* r, double* c, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* rcond, double* rpvgrw, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgbsvxx_work")]
            internal static extern int ZgbsvxxWork(BLAS.LAYOUT matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, System.IntPtr ab, int ldab, System.IntPtr afb, int ldafb, int* ipiv, sbyte* equed, double* r, double* c, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* rcond, double* rpvgrw, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgbtrf")]
            internal static extern int Zgbtrf(BLAS.LAYOUT matrixLayout, int m, int n, int kl, int ku, System.IntPtr ab, int ldab, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgbtrf_work")]
            internal static extern int ZgbtrfWork(BLAS.LAYOUT matrixLayout, int m, int n, int kl, int ku, System.IntPtr ab, int ldab, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgbtrs")]
            internal static extern int Zgbtrs(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, System.IntPtr ab, int ldab, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgbtrs_work")]
            internal static extern int ZgbtrsWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int kl, int ku, int nrhs, System.IntPtr ab, int ldab, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgebak")]
            internal static extern int Zgebak(BLAS.LAYOUT matrixLayout, sbyte job, sbyte side, int n, int ilo, int ihi, double* scale, int m, System.IntPtr v, int ldv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgebak_work")]
            internal static extern int ZgebakWork(BLAS.LAYOUT matrixLayout, sbyte job, sbyte side, int n, int ilo, int ihi, double* scale, int m, System.IntPtr v, int ldv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgebal")]
            internal static extern int Zgebal(BLAS.LAYOUT matrixLayout, sbyte job, int n, System.IntPtr a, int lda, int* ilo, int* ihi, double* scale);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgebal_work")]
            internal static extern int ZgebalWork(BLAS.LAYOUT matrixLayout, sbyte job, int n, System.IntPtr a, int lda, int* ilo, int* ihi, double* scale);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgebrd")]
            internal static extern int Zgebrd(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, double* d, double* e, System.IntPtr tauq, System.IntPtr taup);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgebrd_work")]
            internal static extern int ZgebrdWork(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, double* d, double* e, System.IntPtr tauq, System.IntPtr taup, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgecon")]
            internal static extern int Zgecon(BLAS.LAYOUT matrixLayout, sbyte norm, int n, System.IntPtr a, int lda, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgecon_work")]
            internal static extern int ZgeconWork(BLAS.LAYOUT matrixLayout, sbyte norm, int n, System.IntPtr a, int lda, double anorm, double* rcond, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgeequ")]
            internal static extern int Zgeequ(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, double* r, double* c, double* rowcnd, double* colcnd, double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgeequ_work")]
            internal static extern int ZgeequWork(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, double* r, double* c, double* rowcnd, double* colcnd, double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgeequb")]
            internal static extern int Zgeequb(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, double* r, double* c, double* rowcnd, double* colcnd, double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgeequb_work")]
            internal static extern int ZgeequbWork(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, double* r, double* c, double* rowcnd, double* colcnd, double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgees")]
            internal static extern int Zgees(BLAS.LAYOUT matrixLayout, sbyte jobvs, sbyte sort, System.IntPtr select, int n, System.IntPtr a, int lda, int* sdim, System.IntPtr w, System.IntPtr vs, int ldvs);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgees_work")]
            internal static extern int ZgeesWork(BLAS.LAYOUT matrixLayout, sbyte jobvs, sbyte sort, System.IntPtr select, int n, System.IntPtr a, int lda, int* sdim, System.IntPtr w, System.IntPtr vs, int ldvs, System.IntPtr work, int lwork, double* rwork, int* bwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgeesx")]
            internal static extern int Zgeesx(BLAS.LAYOUT matrixLayout, sbyte jobvs, sbyte sort, System.IntPtr select, sbyte sense, int n, System.IntPtr a, int lda, int* sdim, System.IntPtr w, System.IntPtr vs, int ldvs, double* rconde, double* rcondv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgeesx_work")]
            internal static extern int ZgeesxWork(BLAS.LAYOUT matrixLayout, sbyte jobvs, sbyte sort, System.IntPtr select, sbyte sense, int n, System.IntPtr a, int lda, int* sdim, System.IntPtr w, System.IntPtr vs, int ldvs, double* rconde, double* rcondv, System.IntPtr work, int lwork, double* rwork, int* bwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgeev")]
            internal static extern int Zgeev(BLAS.LAYOUT matrixLayout, sbyte jobvl, sbyte jobvr, int n, System.IntPtr a, int lda, System.IntPtr w, System.IntPtr vl, int ldvl, System.IntPtr vr, int ldvr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgeev_work")]
            internal static extern int ZgeevWork(BLAS.LAYOUT matrixLayout, sbyte jobvl, sbyte jobvr, int n, System.IntPtr a, int lda, System.IntPtr w, System.IntPtr vl, int ldvl, System.IntPtr vr, int ldvr, System.IntPtr work, int lwork, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgeevx")]
            internal static extern int Zgeevx(BLAS.LAYOUT matrixLayout, sbyte balanc, sbyte jobvl, sbyte jobvr, sbyte sense, int n, System.IntPtr a, int lda, System.IntPtr w, System.IntPtr vl, int ldvl, System.IntPtr vr, int ldvr, int* ilo, int* ihi, double* scale, double* abnrm, double* rconde, double* rcondv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgeevx_work")]
            internal static extern int ZgeevxWork(BLAS.LAYOUT matrixLayout, sbyte balanc, sbyte jobvl, sbyte jobvr, sbyte sense, int n, System.IntPtr a, int lda, System.IntPtr w, System.IntPtr vl, int ldvl, System.IntPtr vr, int ldvr, int* ilo, int* ihi, double* scale, double* abnrm, double* rconde, double* rcondv, System.IntPtr work, int lwork, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgehrd")]
            internal static extern int Zgehrd(BLAS.LAYOUT matrixLayout, int n, int ilo, int ihi, System.IntPtr a, int lda, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgehrd_work")]
            internal static extern int ZgehrdWork(BLAS.LAYOUT matrixLayout, int n, int ilo, int ihi, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgejsv")]
            internal static extern int Zgejsv(BLAS.LAYOUT matrixLayout, sbyte joba, sbyte jobu, sbyte jobv, sbyte jobr, sbyte jobt, sbyte jobp, int m, int n, System.IntPtr a, int lda, double* sva, System.IntPtr u, int ldu, System.IntPtr v, int ldv, double* stat, int* istat);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgejsv_work")]
            internal static extern int ZgejsvWork(BLAS.LAYOUT matrixLayout, sbyte joba, sbyte jobu, sbyte jobv, sbyte jobr, sbyte jobt, sbyte jobp, int m, int n, System.IntPtr a, int lda, double* sva, System.IntPtr u, int ldu, System.IntPtr v, int ldv, System.IntPtr cwork, int lwork, double* rwork, int lrwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgelq2")]
            internal static extern int Zgelq2(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgelq2_work")]
            internal static extern int Zgelq2Work(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgelqf")]
            internal static extern int Zgelqf(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgelqf_work")]
            internal static extern int ZgelqfWork(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgels")]
            internal static extern int Zgels(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int m, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgels_work")]
            internal static extern int ZgelsWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int m, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgelsd")]
            internal static extern int Zgelsd(BLAS.LAYOUT matrixLayout, int m, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr b, int ldb, double* s, double rcond, int* rank);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgelsd_work")]
            internal static extern int ZgelsdWork(BLAS.LAYOUT matrixLayout, int m, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr b, int ldb, double* s, double rcond, int* rank, System.IntPtr work, int lwork, double* rwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgelss")]
            internal static extern int Zgelss(BLAS.LAYOUT matrixLayout, int m, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr b, int ldb, double* s, double rcond, int* rank);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgelss_work")]
            internal static extern int ZgelssWork(BLAS.LAYOUT matrixLayout, int m, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr b, int ldb, double* s, double rcond, int* rank, System.IntPtr work, int lwork, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgelsy")]
            internal static extern int Zgelsy(BLAS.LAYOUT matrixLayout, int m, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr b, int ldb, int* jpvt, double rcond, int* rank);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgelsy_work")]
            internal static extern int ZgelsyWork(BLAS.LAYOUT matrixLayout, int m, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr b, int ldb, int* jpvt, double rcond, int* rank, System.IntPtr work, int lwork, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgemqrt")]
            internal static extern int Zgemqrt(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, int nb, System.IntPtr v, int ldv, System.IntPtr t, int ldt, System.IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgemqrt_work")]
            internal static extern int ZgemqrtWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, int nb, System.IntPtr v, int ldv, System.IntPtr t, int ldt, System.IntPtr c, int ldc, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgeqlf")]
            internal static extern int Zgeqlf(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgeqlf_work")]
            internal static extern int ZgeqlfWork(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgeqp3")]
            internal static extern int Zgeqp3(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, int* jpvt, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgeqp3_work")]
            internal static extern int Zgeqp3Work(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, int* jpvt, System.IntPtr tau, System.IntPtr work, int lwork, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgeqpf")]
            internal static extern int Zgeqpf(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, int* jpvt, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgeqpf_work")]
            internal static extern int ZgeqpfWork(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, int* jpvt, System.IntPtr tau, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgeqr2")]
            internal static extern int Zgeqr2(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgeqr2_work")]
            internal static extern int Zgeqr2Work(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgeqrf")]
            internal static extern int Zgeqrf(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgeqrf_work")]
            internal static extern int ZgeqrfWork(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgeqrfp")]
            internal static extern int Zgeqrfp(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgeqrfp_work")]
            internal static extern int ZgeqrfpWork(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgeqrt")]
            internal static extern int Zgeqrt(BLAS.LAYOUT matrixLayout, int m, int n, int nb, System.IntPtr a, int lda, System.IntPtr t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgeqrt2")]
            internal static extern int Zgeqrt2(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgeqrt2_work")]
            internal static extern int Zgeqrt2Work(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgeqrt3")]
            internal static extern int Zgeqrt3(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgeqrt3_work")]
            internal static extern int Zgeqrt3Work(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgeqrt_work")]
            internal static extern int ZgeqrtWork(BLAS.LAYOUT matrixLayout, int m, int n, int nb, System.IntPtr a, int lda, System.IntPtr t, int ldt, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgerfs")]
            internal static extern int Zgerfs(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, int* ipiv, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgerfs_work")]
            internal static extern int ZgerfsWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, int* ipiv, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* ferr, double* berr, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgerfsx")]
            internal static extern int Zgerfsx(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, sbyte equed, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, int* ipiv, double* r, double* c, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* rcond, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgerfsx_work")]
            internal static extern int ZgerfsxWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, sbyte equed, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, int* ipiv, double* r, double* c, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* rcond, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgerqf")]
            internal static extern int Zgerqf(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgerqf_work")]
            internal static extern int ZgerqfWork(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgesdd")]
            internal static extern int Zgesdd(BLAS.LAYOUT matrixLayout, sbyte jobz, int m, int n, System.IntPtr a, int lda, double* s, System.IntPtr u, int ldu, System.IntPtr vt, int ldvt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgesdd_work")]
            internal static extern int ZgesddWork(BLAS.LAYOUT matrixLayout, sbyte jobz, int m, int n, System.IntPtr a, int lda, double* s, System.IntPtr u, int ldu, System.IntPtr vt, int ldvt, System.IntPtr work, int lwork, double* rwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgesv")]
            internal static extern int Zgesv(BLAS.LAYOUT matrixLayout, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgesv_work")]
            internal static extern int ZgesvWork(BLAS.LAYOUT matrixLayout, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgesvd")]
            internal static extern int Zgesvd(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobvt, int m, int n, System.IntPtr a, int lda, double* s, System.IntPtr u, int ldu, System.IntPtr vt, int ldvt, double* superb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgesvd_work")]
            internal static extern int ZgesvdWork(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobvt, int m, int n, System.IntPtr a, int lda, double* s, System.IntPtr u, int ldu, System.IntPtr vt, int ldvt, System.IntPtr work, int lwork, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgesvdx")]
            internal static extern int Zgesvdx(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobvt, sbyte range, int m, int n, System.IntPtr a, int lda, double vl, double vu, int il, int iu, int* ns, double* s, System.IntPtr u, int ldu, System.IntPtr vt, int ldvt, int* superb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgesvdx_work")]
            internal static extern int ZgesvdxWork(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobvt, sbyte range, int m, int n, System.IntPtr a, int lda, double vl, double vu, int il, int iu, int* ns, double* s, System.IntPtr u, int ldu, System.IntPtr vt, int ldvt, System.IntPtr work, int lwork, double* rwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgesvj")]
            internal static extern int Zgesvj(BLAS.LAYOUT matrixLayout, sbyte joba, sbyte jobu, sbyte jobv, int m, int n, System.IntPtr a, int lda, double* sva, int mv, System.IntPtr v, int ldv, double* stat);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgesvj_work")]
            internal static extern int ZgesvjWork(BLAS.LAYOUT matrixLayout, sbyte joba, sbyte jobu, sbyte jobv, int m, int n, System.IntPtr a, int lda, double* sva, int mv, System.IntPtr v, int ldv, System.IntPtr cwork, int lwork, double* rwork, int lrwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgesvx")]
            internal static extern int Zgesvx(BLAS.LAYOUT matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, int* ipiv, sbyte* equed, double* r, double* c, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* rcond, double* ferr, double* berr, double* rpivot);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgesvx_work")]
            internal static extern int ZgesvxWork(BLAS.LAYOUT matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, int* ipiv, sbyte* equed, double* r, double* c, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* rcond, double* ferr, double* berr, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgesvxx")]
            internal static extern int Zgesvxx(BLAS.LAYOUT matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, int* ipiv, sbyte* equed, double* r, double* c, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* rcond, double* rpvgrw, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgesvxx_work")]
            internal static extern int ZgesvxxWork(BLAS.LAYOUT matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, int* ipiv, sbyte* equed, double* r, double* c, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* rcond, double* rpvgrw, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgetf2")]
            internal static extern int Zgetf2(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgetf2_work")]
            internal static extern int Zgetf2Work(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgetrf")]
            internal static extern int Zgetrf(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgetrf2")]
            internal static extern int Zgetrf2(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgetrf2_work")]
            internal static extern int Zgetrf2Work(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgetrf_work")]
            internal static extern int ZgetrfWork(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgetri")]
            internal static extern int Zgetri(BLAS.LAYOUT matrixLayout, int n, System.IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgetri_work")]
            internal static extern int ZgetriWork(BLAS.LAYOUT matrixLayout, int n, System.IntPtr a, int lda, int* ipiv, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgetrs")]
            internal static extern int Zgetrs(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgetrs_work")]
            internal static extern int ZgetrsWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zggbak")]
            internal static extern int Zggbak(BLAS.LAYOUT matrixLayout, sbyte job, sbyte side, int n, int ilo, int ihi, double* lscale, double* rscale, int m, System.IntPtr v, int ldv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zggbak_work")]
            internal static extern int ZggbakWork(BLAS.LAYOUT matrixLayout, sbyte job, sbyte side, int n, int ilo, int ihi, double* lscale, double* rscale, int m, System.IntPtr v, int ldv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zggbal")]
            internal static extern int Zggbal(BLAS.LAYOUT matrixLayout, sbyte job, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, int* ilo, int* ihi, double* lscale, double* rscale);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zggbal_work")]
            internal static extern int ZggbalWork(BLAS.LAYOUT matrixLayout, sbyte job, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, int* ilo, int* ihi, double* lscale, double* rscale, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgges")]
            internal static extern int Zgges(BLAS.LAYOUT matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, System.IntPtr selctg, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, int* sdim, System.IntPtr alpha, System.IntPtr beta, System.IntPtr vsl, int ldvsl, System.IntPtr vsr, int ldvsr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgges3")]
            internal static extern int Zgges3(BLAS.LAYOUT matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, System.IntPtr selctg, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, int* sdim, System.IntPtr alpha, System.IntPtr beta, System.IntPtr vsl, int ldvsl, System.IntPtr vsr, int ldvsr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgges3_work")]
            internal static extern int Zgges3Work(BLAS.LAYOUT matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, System.IntPtr selctg, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, int* sdim, System.IntPtr alpha, System.IntPtr beta, System.IntPtr vsl, int ldvsl, System.IntPtr vsr, int ldvsr, System.IntPtr work, int lwork, double* rwork, int* bwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgges_work")]
            internal static extern int ZggesWork(BLAS.LAYOUT matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, System.IntPtr selctg, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, int* sdim, System.IntPtr alpha, System.IntPtr beta, System.IntPtr vsl, int ldvsl, System.IntPtr vsr, int ldvsr, System.IntPtr work, int lwork, double* rwork, int* bwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zggesx")]
            internal static extern int Zggesx(BLAS.LAYOUT matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, System.IntPtr selctg, sbyte sense, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, int* sdim, System.IntPtr alpha, System.IntPtr beta, System.IntPtr vsl, int ldvsl, System.IntPtr vsr, int ldvsr, double* rconde, double* rcondv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zggesx_work")]
            internal static extern int ZggesxWork(BLAS.LAYOUT matrixLayout, sbyte jobvsl, sbyte jobvsr, sbyte sort, System.IntPtr selctg, sbyte sense, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, int* sdim, System.IntPtr alpha, System.IntPtr beta, System.IntPtr vsl, int ldvsl, System.IntPtr vsr, int ldvsr, double* rconde, double* rcondv, System.IntPtr work, int lwork, double* rwork, int* iwork, int liwork, int* bwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zggev")]
            internal static extern int Zggev(BLAS.LAYOUT matrixLayout, sbyte jobvl, sbyte jobvr, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr alpha, System.IntPtr beta, System.IntPtr vl, int ldvl, System.IntPtr vr, int ldvr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zggev3")]
            internal static extern int Zggev3(BLAS.LAYOUT matrixLayout, sbyte jobvl, sbyte jobvr, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr alpha, System.IntPtr beta, System.IntPtr vl, int ldvl, System.IntPtr vr, int ldvr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zggev3_work")]
            internal static extern int Zggev3Work(BLAS.LAYOUT matrixLayout, sbyte jobvl, sbyte jobvr, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr alpha, System.IntPtr beta, System.IntPtr vl, int ldvl, System.IntPtr vr, int ldvr, System.IntPtr work, int lwork, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zggev_work")]
            internal static extern int ZggevWork(BLAS.LAYOUT matrixLayout, sbyte jobvl, sbyte jobvr, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr alpha, System.IntPtr beta, System.IntPtr vl, int ldvl, System.IntPtr vr, int ldvr, System.IntPtr work, int lwork, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zggevx")]
            internal static extern int Zggevx(BLAS.LAYOUT matrixLayout, sbyte balanc, sbyte jobvl, sbyte jobvr, sbyte sense, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr alpha, System.IntPtr beta, System.IntPtr vl, int ldvl, System.IntPtr vr, int ldvr, int* ilo, int* ihi, double* lscale, double* rscale, double* abnrm, double* bbnrm, double* rconde, double* rcondv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zggevx_work")]
            internal static extern int ZggevxWork(BLAS.LAYOUT matrixLayout, sbyte balanc, sbyte jobvl, sbyte jobvr, sbyte sense, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr alpha, System.IntPtr beta, System.IntPtr vl, int ldvl, System.IntPtr vr, int ldvr, int* ilo, int* ihi, double* lscale, double* rscale, double* abnrm, double* bbnrm, double* rconde, double* rcondv, System.IntPtr work, int lwork, double* rwork, int* iwork, int* bwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zggglm")]
            internal static extern int Zggglm(BLAS.LAYOUT matrixLayout, int n, int m, int p, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr d, System.IntPtr x, System.IntPtr y);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zggglm_work")]
            internal static extern int ZggglmWork(BLAS.LAYOUT matrixLayout, int n, int m, int p, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr d, System.IntPtr x, System.IntPtr y, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgghd3")]
            internal static extern int Zgghd3(BLAS.LAYOUT matrixLayout, sbyte compq, sbyte compz, int n, int ilo, int ihi, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr q, int ldq, System.IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgghd3_work")]
            internal static extern int Zgghd3Work(BLAS.LAYOUT matrixLayout, sbyte compq, sbyte compz, int n, int ilo, int ihi, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr q, int ldq, System.IntPtr z, int ldz, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgghrd")]
            internal static extern int Zgghrd(BLAS.LAYOUT matrixLayout, sbyte compq, sbyte compz, int n, int ilo, int ihi, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr q, int ldq, System.IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgghrd_work")]
            internal static extern int ZgghrdWork(BLAS.LAYOUT matrixLayout, sbyte compq, sbyte compz, int n, int ilo, int ihi, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr q, int ldq, System.IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgglse")]
            internal static extern int Zgglse(BLAS.LAYOUT matrixLayout, int m, int n, int p, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr c, System.IntPtr d, System.IntPtr x);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgglse_work")]
            internal static extern int ZgglseWork(BLAS.LAYOUT matrixLayout, int m, int n, int p, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr c, System.IntPtr d, System.IntPtr x, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zggqrf")]
            internal static extern int Zggqrf(BLAS.LAYOUT matrixLayout, int n, int m, int p, System.IntPtr a, int lda, System.IntPtr taua, System.IntPtr b, int ldb, System.IntPtr taub);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zggqrf_work")]
            internal static extern int ZggqrfWork(BLAS.LAYOUT matrixLayout, int n, int m, int p, System.IntPtr a, int lda, System.IntPtr taua, System.IntPtr b, int ldb, System.IntPtr taub, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zggrqf")]
            internal static extern int Zggrqf(BLAS.LAYOUT matrixLayout, int m, int p, int n, System.IntPtr a, int lda, System.IntPtr taua, System.IntPtr b, int ldb, System.IntPtr taub);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zggrqf_work")]
            internal static extern int ZggrqfWork(BLAS.LAYOUT matrixLayout, int m, int p, int n, System.IntPtr a, int lda, System.IntPtr taua, System.IntPtr b, int ldb, System.IntPtr taub, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zggsvd")]
            internal static extern int Zggsvd(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int n, int p, int* k, int* l, System.IntPtr a, int lda, System.IntPtr b, int ldb, double* alpha, double* beta, System.IntPtr u, int ldu, System.IntPtr v, int ldv, System.IntPtr q, int ldq, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zggsvd3")]
            internal static extern int Zggsvd3(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int n, int p, int* k, int* l, System.IntPtr a, int lda, System.IntPtr b, int ldb, double* alpha, double* beta, System.IntPtr u, int ldu, System.IntPtr v, int ldv, System.IntPtr q, int ldq, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zggsvd3_work")]
            internal static extern int Zggsvd3Work(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int n, int p, int* k, int* l, System.IntPtr a, int lda, System.IntPtr b, int ldb, double* alpha, double* beta, System.IntPtr u, int ldu, System.IntPtr v, int ldv, System.IntPtr q, int ldq, System.IntPtr work, int lwork, double* rwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zggsvd_work")]
            internal static extern int ZggsvdWork(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int n, int p, int* k, int* l, System.IntPtr a, int lda, System.IntPtr b, int ldb, double* alpha, double* beta, System.IntPtr u, int ldu, System.IntPtr v, int ldv, System.IntPtr q, int ldq, System.IntPtr work, double* rwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zggsvp")]
            internal static extern int Zggsvp(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, double tola, double tolb, int* k, int* l, System.IntPtr u, int ldu, System.IntPtr v, int ldv, System.IntPtr q, int ldq);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zggsvp3")]
            internal static extern int Zggsvp3(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, double tola, double tolb, int* k, int* l, System.IntPtr u, int ldu, System.IntPtr v, int ldv, System.IntPtr q, int ldq);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zggsvp3_work")]
            internal static extern int Zggsvp3Work(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, double tola, double tolb, int* k, int* l, System.IntPtr u, int ldu, System.IntPtr v, int ldv, System.IntPtr q, int ldq, int* iwork, double* rwork, System.IntPtr tau, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zggsvp_work")]
            internal static extern int ZggsvpWork(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, double tola, double tolb, int* k, int* l, System.IntPtr u, int ldu, System.IntPtr v, int ldv, System.IntPtr q, int ldq, int* iwork, double* rwork, System.IntPtr tau, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgtcon")]
            internal static extern int Zgtcon(sbyte norm, int n, System.IntPtr dl, System.IntPtr d, System.IntPtr du, System.IntPtr du2, int* ipiv, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgtcon_work")]
            internal static extern int ZgtconWork(sbyte norm, int n, System.IntPtr dl, System.IntPtr d, System.IntPtr du, System.IntPtr du2, int* ipiv, double anorm, double* rcond, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgtrfs")]
            internal static extern int Zgtrfs(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int nrhs, System.IntPtr dl, System.IntPtr d, System.IntPtr du, System.IntPtr dlf, System.IntPtr df, System.IntPtr duf, System.IntPtr du2, int* ipiv, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgtrfs_work")]
            internal static extern int ZgtrfsWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int nrhs, System.IntPtr dl, System.IntPtr d, System.IntPtr du, System.IntPtr dlf, System.IntPtr df, System.IntPtr duf, System.IntPtr du2, int* ipiv, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* ferr, double* berr, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgtsv")]
            internal static extern int Zgtsv(BLAS.LAYOUT matrixLayout, int n, int nrhs, System.IntPtr dl, System.IntPtr d, System.IntPtr du, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgtsv_work")]
            internal static extern int ZgtsvWork(BLAS.LAYOUT matrixLayout, int n, int nrhs, System.IntPtr dl, System.IntPtr d, System.IntPtr du, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgtsvx")]
            internal static extern int Zgtsvx(BLAS.LAYOUT matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int nrhs, System.IntPtr dl, System.IntPtr d, System.IntPtr du, System.IntPtr dlf, System.IntPtr df, System.IntPtr duf, System.IntPtr du2, int* ipiv, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* rcond, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgtsvx_work")]
            internal static extern int ZgtsvxWork(BLAS.LAYOUT matrixLayout, sbyte fact, BLAS.TRANS trans, int n, int nrhs, System.IntPtr dl, System.IntPtr d, System.IntPtr du, System.IntPtr dlf, System.IntPtr df, System.IntPtr duf, System.IntPtr du2, int* ipiv, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* rcond, double* ferr, double* berr, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgttrf")]
            internal static extern int Zgttrf(int n, System.IntPtr dl, System.IntPtr d, System.IntPtr du, System.IntPtr du2, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgttrf_work")]
            internal static extern int ZgttrfWork(int n, System.IntPtr dl, System.IntPtr d, System.IntPtr du, System.IntPtr du2, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgttrs")]
            internal static extern int Zgttrs(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int nrhs, System.IntPtr dl, System.IntPtr d, System.IntPtr du, System.IntPtr du2, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgttrs_work")]
            internal static extern int ZgttrsWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int n, int nrhs, System.IntPtr dl, System.IntPtr d, System.IntPtr du, System.IntPtr du2, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhbev")]
            internal static extern int Zhbev(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, System.IntPtr ab, int ldab, double* w, System.IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhbev_work")]
            internal static extern int ZhbevWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, System.IntPtr ab, int ldab, double* w, System.IntPtr z, int ldz, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhbevd")]
            internal static extern int Zhbevd(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, System.IntPtr ab, int ldab, double* w, System.IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhbevd_work")]
            internal static extern int ZhbevdWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, System.IntPtr ab, int ldab, double* w, System.IntPtr z, int ldz, System.IntPtr work, int lwork, double* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhbevx")]
            internal static extern int Zhbevx(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, int kd, System.IntPtr ab, int ldab, System.IntPtr q, int ldq, double vl, double vu, int il, int iu, double abstol, int* m, double* w, System.IntPtr z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhbevx_work")]
            internal static extern int ZhbevxWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, int kd, System.IntPtr ab, int ldab, System.IntPtr q, int ldq, double vl, double vu, int il, int iu, double abstol, int* m, double* w, System.IntPtr z, int ldz, System.IntPtr work, double* rwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhbgst")]
            internal static extern int Zhbgst(BLAS.LAYOUT matrixLayout, sbyte vect, sbyte uplo, int n, int ka, int kb, System.IntPtr ab, int ldab, System.IntPtr bb, int ldbb, System.IntPtr x, int ldx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhbgst_work")]
            internal static extern int ZhbgstWork(BLAS.LAYOUT matrixLayout, sbyte vect, sbyte uplo, int n, int ka, int kb, System.IntPtr ab, int ldab, System.IntPtr bb, int ldbb, System.IntPtr x, int ldx, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhbgv")]
            internal static extern int Zhbgv(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int ka, int kb, System.IntPtr ab, int ldab, System.IntPtr bb, int ldbb, double* w, System.IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhbgv_work")]
            internal static extern int ZhbgvWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int ka, int kb, System.IntPtr ab, int ldab, System.IntPtr bb, int ldbb, double* w, System.IntPtr z, int ldz, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhbgvd")]
            internal static extern int Zhbgvd(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int ka, int kb, System.IntPtr ab, int ldab, System.IntPtr bb, int ldbb, double* w, System.IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhbgvd_work")]
            internal static extern int ZhbgvdWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int ka, int kb, System.IntPtr ab, int ldab, System.IntPtr bb, int ldbb, double* w, System.IntPtr z, int ldz, System.IntPtr work, int lwork, double* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhbgvx")]
            internal static extern int Zhbgvx(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, int ka, int kb, System.IntPtr ab, int ldab, System.IntPtr bb, int ldbb, System.IntPtr q, int ldq, double vl, double vu, int il, int iu, double abstol, int* m, double* w, System.IntPtr z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhbgvx_work")]
            internal static extern int ZhbgvxWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, int ka, int kb, System.IntPtr ab, int ldab, System.IntPtr bb, int ldbb, System.IntPtr q, int ldq, double vl, double vu, int il, int iu, double abstol, int* m, double* w, System.IntPtr z, int ldz, System.IntPtr work, double* rwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhbtrd")]
            internal static extern int Zhbtrd(BLAS.LAYOUT matrixLayout, sbyte vect, sbyte uplo, int n, int kd, System.IntPtr ab, int ldab, double* d, double* e, System.IntPtr q, int ldq);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhbtrd_work")]
            internal static extern int ZhbtrdWork(BLAS.LAYOUT matrixLayout, sbyte vect, sbyte uplo, int n, int kd, System.IntPtr ab, int ldab, double* d, double* e, System.IntPtr q, int ldq, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhecon")]
            internal static extern int Zhecon(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhecon_work")]
            internal static extern int ZheconWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv, double anorm, double* rcond, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zheequb")]
            internal static extern int Zheequb(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, double* s, double* scond, double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zheequb_work")]
            internal static extern int ZheequbWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, double* s, double* scond, double* amax, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zheev")]
            internal static extern int Zheev(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, System.IntPtr a, int lda, double* w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zheev_work")]
            internal static extern int ZheevWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, System.IntPtr a, int lda, double* w, System.IntPtr work, int lwork, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zheevd")]
            internal static extern int Zheevd(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, System.IntPtr a, int lda, double* w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zheevd_work")]
            internal static extern int ZheevdWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, System.IntPtr a, int lda, double* w, System.IntPtr work, int lwork, double* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zheevr")]
            internal static extern int Zheevr(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, System.IntPtr a, int lda, double vl, double vu, int il, int iu, double abstol, int* m, double* w, System.IntPtr z, int ldz, int* isuppz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zheevr_work")]
            internal static extern int ZheevrWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, System.IntPtr a, int lda, double vl, double vu, int il, int iu, double abstol, int* m, double* w, System.IntPtr z, int ldz, int* isuppz, System.IntPtr work, int lwork, double* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zheevx")]
            internal static extern int Zheevx(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, System.IntPtr a, int lda, double vl, double vu, int il, int iu, double abstol, int* m, double* w, System.IntPtr z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zheevx_work")]
            internal static extern int ZheevxWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, System.IntPtr a, int lda, double vl, double vu, int il, int iu, double abstol, int* m, double* w, System.IntPtr z, int ldz, System.IntPtr work, int lwork, double* rwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhegst")]
            internal static extern int Zhegst(BLAS.LAYOUT matrixLayout, int itype, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhegst_work")]
            internal static extern int ZhegstWork(BLAS.LAYOUT matrixLayout, int itype, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhegv")]
            internal static extern int Zhegv(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, double* w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhegv_work")]
            internal static extern int ZhegvWork(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, double* w, System.IntPtr work, int lwork, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhegvd")]
            internal static extern int Zhegvd(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, double* w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhegvd_work")]
            internal static extern int ZhegvdWork(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, double* w, System.IntPtr work, int lwork, double* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhegvx")]
            internal static extern int Zhegvx(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte range, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, double vl, double vu, int il, int iu, double abstol, int* m, double* w, System.IntPtr z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhegvx_work")]
            internal static extern int ZhegvxWork(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte range, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, double vl, double vu, int il, int iu, double abstol, int* m, double* w, System.IntPtr z, int ldz, System.IntPtr work, int lwork, double* rwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zherfs")]
            internal static extern int Zherfs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, int* ipiv, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zherfs_work")]
            internal static extern int ZherfsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, int* ipiv, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* ferr, double* berr, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zherfsx")]
            internal static extern int Zherfsx(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte equed, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, int* ipiv, double* s, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* rcond, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zherfsx_work")]
            internal static extern int ZherfsxWork(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte equed, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, int* ipiv, double* s, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* rcond, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhesv")]
            internal static extern int Zhesv(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhesv_work")]
            internal static extern int ZhesvWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhesvx")]
            internal static extern int Zhesvx(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, int* ipiv, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* rcond, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhesvx_work")]
            internal static extern int ZhesvxWork(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, int* ipiv, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* rcond, double* ferr, double* berr, System.IntPtr work, int lwork, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhesvxx")]
            internal static extern int Zhesvxx(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, int* ipiv, sbyte* equed, double* s, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* rcond, double* rpvgrw, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhesvxx_work")]
            internal static extern int ZhesvxxWork(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, int* ipiv, sbyte* equed, double* s, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* rcond, double* rpvgrw, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zheswapr")]
            internal static extern int Zheswapr(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int i1, int i2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zheswapr_work")]
            internal static extern int ZheswaprWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int i1, int i2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhetrd")]
            internal static extern int Zhetrd(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, double* d, double* e, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhetrd_work")]
            internal static extern int ZhetrdWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, double* d, double* e, System.IntPtr tau, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhetrf")]
            internal static extern int Zhetrf(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhetrf_rook")]
            internal static extern int ZhetrfRook(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhetrf_rook_work")]
            internal static extern int ZhetrfRookWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhetrf_work")]
            internal static extern int ZhetrfWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhetri")]
            internal static extern int Zhetri(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhetri2")]
            internal static extern int Zhetri2(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhetri2_work")]
            internal static extern int Zhetri2Work(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhetri2x")]
            internal static extern int Zhetri2x(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv, int nb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhetri2x_work")]
            internal static extern int Zhetri2xWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv, System.IntPtr work, int nb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhetri_work")]
            internal static extern int ZhetriWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhetrs")]
            internal static extern int Zhetrs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhetrs2")]
            internal static extern int Zhetrs2(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhetrs2_work")]
            internal static extern int Zhetrs2Work(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhetrs_rook")]
            internal static extern int ZhetrsRook(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhetrs_rook_work")]
            internal static extern int ZhetrsRookWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhetrs_work")]
            internal static extern int ZhetrsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhfrk")]
            internal static extern int Zhfrk(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, BLAS.TRANS trans, int n, int k, double alpha, System.IntPtr a, int lda, double beta, System.IntPtr c);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhfrk_work")]
            internal static extern int ZhfrkWork(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, BLAS.TRANS trans, int n, int k, double alpha, System.IntPtr a, int lda, double beta, System.IntPtr c);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhgeqz")]
            internal static extern int Zhgeqz(BLAS.LAYOUT matrixLayout, sbyte job, sbyte compq, sbyte compz, int n, int ilo, int ihi, System.IntPtr h, int ldh, System.IntPtr t, int ldt, System.IntPtr alpha, System.IntPtr beta, System.IntPtr q, int ldq, System.IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhgeqz_work")]
            internal static extern int ZhgeqzWork(BLAS.LAYOUT matrixLayout, sbyte job, sbyte compq, sbyte compz, int n, int ilo, int ihi, System.IntPtr h, int ldh, System.IntPtr t, int ldt, System.IntPtr alpha, System.IntPtr beta, System.IntPtr q, int ldq, System.IntPtr z, int ldz, System.IntPtr work, int lwork, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhpcon")]
            internal static extern int Zhpcon(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, int* ipiv, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhpcon_work")]
            internal static extern int ZhpconWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, int* ipiv, double anorm, double* rcond, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhpev")]
            internal static extern int Zhpev(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, System.IntPtr ap, double* w, System.IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhpev_work")]
            internal static extern int ZhpevWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, System.IntPtr ap, double* w, System.IntPtr z, int ldz, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhpevd")]
            internal static extern int Zhpevd(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, System.IntPtr ap, double* w, System.IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhpevd_work")]
            internal static extern int ZhpevdWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, System.IntPtr ap, double* w, System.IntPtr z, int ldz, System.IntPtr work, int lwork, double* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhpevx")]
            internal static extern int Zhpevx(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, System.IntPtr ap, double vl, double vu, int il, int iu, double abstol, int* m, double* w, System.IntPtr z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhpevx_work")]
            internal static extern int ZhpevxWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, System.IntPtr ap, double vl, double vu, int il, int iu, double abstol, int* m, double* w, System.IntPtr z, int ldz, System.IntPtr work, double* rwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhpgst")]
            internal static extern int Zhpgst(BLAS.LAYOUT matrixLayout, int itype, sbyte uplo, int n, System.IntPtr ap, System.IntPtr bp);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhpgst_work")]
            internal static extern int ZhpgstWork(BLAS.LAYOUT matrixLayout, int itype, sbyte uplo, int n, System.IntPtr ap, System.IntPtr bp);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhpgv")]
            internal static extern int Zhpgv(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, System.IntPtr ap, System.IntPtr bp, double* w, System.IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhpgv_work")]
            internal static extern int ZhpgvWork(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, System.IntPtr ap, System.IntPtr bp, double* w, System.IntPtr z, int ldz, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhpgvd")]
            internal static extern int Zhpgvd(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, System.IntPtr ap, System.IntPtr bp, double* w, System.IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhpgvd_work")]
            internal static extern int ZhpgvdWork(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, System.IntPtr ap, System.IntPtr bp, double* w, System.IntPtr z, int ldz, System.IntPtr work, int lwork, double* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhpgvx")]
            internal static extern int Zhpgvx(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte range, sbyte uplo, int n, System.IntPtr ap, System.IntPtr bp, double vl, double vu, int il, int iu, double abstol, int* m, double* w, System.IntPtr z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhpgvx_work")]
            internal static extern int ZhpgvxWork(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte range, sbyte uplo, int n, System.IntPtr ap, System.IntPtr bp, double vl, double vu, int il, int iu, double abstol, int* m, double* w, System.IntPtr z, int ldz, System.IntPtr work, double* rwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhprfs")]
            internal static extern int Zhprfs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr ap, System.IntPtr afp, int* ipiv, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhprfs_work")]
            internal static extern int ZhprfsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr ap, System.IntPtr afp, int* ipiv, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* ferr, double* berr, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhpsv")]
            internal static extern int Zhpsv(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr ap, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhpsv_work")]
            internal static extern int ZhpsvWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr ap, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhpsvx")]
            internal static extern int Zhpsvx(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, System.IntPtr ap, System.IntPtr afp, int* ipiv, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* rcond, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhpsvx_work")]
            internal static extern int ZhpsvxWork(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, System.IntPtr ap, System.IntPtr afp, int* ipiv, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* rcond, double* ferr, double* berr, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhptrd")]
            internal static extern int Zhptrd(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, double* d, double* e, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhptrd_work")]
            internal static extern int ZhptrdWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, double* d, double* e, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhptrf")]
            internal static extern int Zhptrf(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhptrf_work")]
            internal static extern int ZhptrfWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhptri")]
            internal static extern int Zhptri(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhptri_work")]
            internal static extern int ZhptriWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, int* ipiv, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhptrs")]
            internal static extern int Zhptrs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr ap, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhptrs_work")]
            internal static extern int ZhptrsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr ap, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhsein")]
            internal static extern int Zhsein(BLAS.LAYOUT matrixLayout, sbyte job, sbyte eigsrc, sbyte initv, int* select, int n, System.IntPtr h, int ldh, System.IntPtr w, System.IntPtr vl, int ldvl, System.IntPtr vr, int ldvr, int mm, int* m, int* ifaill, int* ifailr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhsein_work")]
            internal static extern int ZhseinWork(BLAS.LAYOUT matrixLayout, sbyte job, sbyte eigsrc, sbyte initv, int* select, int n, System.IntPtr h, int ldh, System.IntPtr w, System.IntPtr vl, int ldvl, System.IntPtr vr, int ldvr, int mm, int* m, System.IntPtr work, double* rwork, int* ifaill, int* ifailr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhseqr")]
            internal static extern int Zhseqr(BLAS.LAYOUT matrixLayout, sbyte job, sbyte compz, int n, int ilo, int ihi, System.IntPtr h, int ldh, System.IntPtr w, System.IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhseqr_work")]
            internal static extern int ZhseqrWork(BLAS.LAYOUT matrixLayout, sbyte job, sbyte compz, int n, int ilo, int ihi, System.IntPtr h, int ldh, System.IntPtr w, System.IntPtr z, int ldz, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zlacgv")]
            internal static extern int Zlacgv(int n, System.IntPtr x, int incx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zlacgv_work")]
            internal static extern int ZlacgvWork(int n, System.IntPtr x, int incx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zlacn2")]
            internal static extern int Zlacn2(int n, System.IntPtr v, System.IntPtr x, double* est, int* kase, int* isave);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zlacn2_work")]
            internal static extern int Zlacn2Work(int n, System.IntPtr v, System.IntPtr x, double* est, int* kase, int* isave);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zlacp2")]
            internal static extern int Zlacp2(BLAS.LAYOUT matrixLayout, sbyte uplo, int m, int n, double* a, int lda, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zlacp2_work")]
            internal static extern int Zlacp2Work(BLAS.LAYOUT matrixLayout, sbyte uplo, int m, int n, double* a, int lda, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zlacpy")]
            internal static extern int Zlacpy(BLAS.LAYOUT matrixLayout, sbyte uplo, int m, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zlacpy_work")]
            internal static extern int ZlacpyWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int m, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zlag2c")]
            internal static extern int Zlag2c(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr sa, int ldsa);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zlag2c_work")]
            internal static extern int Zlag2cWork(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr sa, int ldsa);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zlagge")]
            internal static extern int Zlagge(BLAS.LAYOUT matrixLayout, int m, int n, int kl, int ku, double* d, System.IntPtr a, int lda, int* iseed);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zlagge_work")]
            internal static extern int ZlaggeWork(BLAS.LAYOUT matrixLayout, int m, int n, int kl, int ku, double* d, System.IntPtr a, int lda, int* iseed, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zlaghe")]
            internal static extern int Zlaghe(BLAS.LAYOUT matrixLayout, int n, int k, double* d, System.IntPtr a, int lda, int* iseed);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zlaghe_work")]
            internal static extern int ZlagheWork(BLAS.LAYOUT matrixLayout, int n, int k, double* d, System.IntPtr a, int lda, int* iseed, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zlagsy")]
            internal static extern int Zlagsy(BLAS.LAYOUT matrixLayout, int n, int k, double* d, System.IntPtr a, int lda, int* iseed);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zlagsy_work")]
            internal static extern int ZlagsyWork(BLAS.LAYOUT matrixLayout, int n, int k, double* d, System.IntPtr a, int lda, int* iseed, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zlapmr")]
            internal static extern int Zlapmr(BLAS.LAYOUT matrixLayout, int forwrd, int m, int n, System.IntPtr x, int ldx, int* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zlapmr_work")]
            internal static extern int ZlapmrWork(BLAS.LAYOUT matrixLayout, int forwrd, int m, int n, System.IntPtr x, int ldx, int* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zlapmt")]
            internal static extern int Zlapmt(BLAS.LAYOUT matrixLayout, int forwrd, int m, int n, System.IntPtr x, int ldx, int* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zlapmt_work")]
            internal static extern int ZlapmtWork(BLAS.LAYOUT matrixLayout, int forwrd, int m, int n, System.IntPtr x, int ldx, int* k);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zlarfb")]
            internal static extern int Zlarfb(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, sbyte direct, sbyte storev, int m, int n, int k, System.IntPtr v, int ldv, System.IntPtr t, int ldt, System.IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zlarfb_work")]
            internal static extern int ZlarfbWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, sbyte direct, sbyte storev, int m, int n, int k, System.IntPtr v, int ldv, System.IntPtr t, int ldt, System.IntPtr c, int ldc, System.IntPtr work, int ldwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zlarfg")]
            internal static extern int Zlarfg(int n, System.IntPtr alpha, System.IntPtr x, int incx, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zlarfg_work")]
            internal static extern int ZlarfgWork(int n, System.IntPtr alpha, System.IntPtr x, int incx, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zlarft")]
            internal static extern int Zlarft(BLAS.LAYOUT matrixLayout, sbyte direct, sbyte storev, int n, int k, System.IntPtr v, int ldv, System.IntPtr tau, System.IntPtr t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zlarft_work")]
            internal static extern int ZlarftWork(BLAS.LAYOUT matrixLayout, sbyte direct, sbyte storev, int n, int k, System.IntPtr v, int ldv, System.IntPtr tau, System.IntPtr t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zlarfx")]
            internal static extern int Zlarfx(BLAS.LAYOUT matrixLayout, sbyte side, int m, int n, System.IntPtr v, System.IntPtr tau, System.IntPtr c, int ldc, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zlarfx_work")]
            internal static extern int ZlarfxWork(BLAS.LAYOUT matrixLayout, sbyte side, int m, int n, System.IntPtr v, System.IntPtr tau, System.IntPtr c, int ldc, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zlarnv")]
            internal static extern int Zlarnv(int idist, int* iseed, int n, System.IntPtr x);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zlarnv_work")]
            internal static extern int ZlarnvWork(int idist, int* iseed, int n, System.IntPtr x);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zlascl")]
            internal static extern int Zlascl(BLAS.LAYOUT matrixLayout, sbyte type, int kl, int ku, double cfrom, double cto, int m, int n, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zlascl_work")]
            internal static extern int ZlasclWork(BLAS.LAYOUT matrixLayout, sbyte type, int kl, int ku, double cfrom, double cto, int m, int n, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zlaset")]
            internal static extern int Zlaset(BLAS.LAYOUT matrixLayout, sbyte uplo, int m, int n, System.IntPtr alpha, System.IntPtr beta, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zlaset_work")]
            internal static extern int ZlasetWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int m, int n, System.IntPtr alpha, System.IntPtr beta, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zlaswp")]
            internal static extern int Zlaswp(BLAS.LAYOUT matrixLayout, int n, System.IntPtr a, int lda, int k1, int k2, int* ipiv, int incx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zlaswp_work")]
            internal static extern int ZlaswpWork(BLAS.LAYOUT matrixLayout, int n, System.IntPtr a, int lda, int k1, int k2, int* ipiv, int incx);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zlatms")]
            internal static extern int Zlatms(BLAS.LAYOUT matrixLayout, int m, int n, sbyte dist, int* iseed, sbyte sym, double* d, int mode, double cond, double dmax, int kl, int ku, sbyte pack, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zlatms_work")]
            internal static extern int ZlatmsWork(BLAS.LAYOUT matrixLayout, int m, int n, sbyte dist, int* iseed, sbyte sym, double* d, int mode, double cond, double dmax, int kl, int ku, sbyte pack, System.IntPtr a, int lda, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zlauum")]
            internal static extern int Zlauum(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zlauum_work")]
            internal static extern int ZlauumWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zpbcon")]
            internal static extern int Zpbcon(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, System.IntPtr ab, int ldab, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zpbcon_work")]
            internal static extern int ZpbconWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, System.IntPtr ab, int ldab, double anorm, double* rcond, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zpbequ")]
            internal static extern int Zpbequ(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, System.IntPtr ab, int ldab, double* s, double* scond, double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zpbequ_work")]
            internal static extern int ZpbequWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, System.IntPtr ab, int ldab, double* s, double* scond, double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zpbrfs")]
            internal static extern int Zpbrfs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, int nrhs, System.IntPtr ab, int ldab, System.IntPtr afb, int ldafb, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zpbrfs_work")]
            internal static extern int ZpbrfsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, int nrhs, System.IntPtr ab, int ldab, System.IntPtr afb, int ldafb, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* ferr, double* berr, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zpbstf")]
            internal static extern int Zpbstf(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kb, System.IntPtr bb, int ldbb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zpbstf_work")]
            internal static extern int ZpbstfWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kb, System.IntPtr bb, int ldbb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zpbsv")]
            internal static extern int Zpbsv(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, int nrhs, System.IntPtr ab, int ldab, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zpbsv_work")]
            internal static extern int ZpbsvWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, int nrhs, System.IntPtr ab, int ldab, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zpbsvx")]
            internal static extern int Zpbsvx(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int kd, int nrhs, System.IntPtr ab, int ldab, System.IntPtr afb, int ldafb, sbyte* equed, double* s, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* rcond, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zpbsvx_work")]
            internal static extern int ZpbsvxWork(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int kd, int nrhs, System.IntPtr ab, int ldab, System.IntPtr afb, int ldafb, sbyte* equed, double* s, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* rcond, double* ferr, double* berr, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zpbtrf")]
            internal static extern int Zpbtrf(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, System.IntPtr ab, int ldab);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zpbtrf_work")]
            internal static extern int ZpbtrfWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, System.IntPtr ab, int ldab);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zpbtrs")]
            internal static extern int Zpbtrs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, int nrhs, System.IntPtr ab, int ldab, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zpbtrs_work")]
            internal static extern int ZpbtrsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int kd, int nrhs, System.IntPtr ab, int ldab, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zpftrf")]
            internal static extern int Zpftrf(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, System.IntPtr a);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zpftrf_work")]
            internal static extern int ZpftrfWork(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, System.IntPtr a);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zpftri")]
            internal static extern int Zpftri(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, System.IntPtr a);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zpftri_work")]
            internal static extern int ZpftriWork(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, System.IntPtr a);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zpftrs")]
            internal static extern int Zpftrs(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, int nrhs, System.IntPtr a, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zpftrs_work")]
            internal static extern int ZpftrsWork(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, int nrhs, System.IntPtr a, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zpocon")]
            internal static extern int Zpocon(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zpocon_work")]
            internal static extern int ZpoconWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, double anorm, double* rcond, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zpoequ")]
            internal static extern int Zpoequ(BLAS.LAYOUT matrixLayout, int n, System.IntPtr a, int lda, double* s, double* scond, double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zpoequ_work")]
            internal static extern int ZpoequWork(BLAS.LAYOUT matrixLayout, int n, System.IntPtr a, int lda, double* s, double* scond, double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zpoequb")]
            internal static extern int Zpoequb(BLAS.LAYOUT matrixLayout, int n, System.IntPtr a, int lda, double* s, double* scond, double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zpoequb_work")]
            internal static extern int ZpoequbWork(BLAS.LAYOUT matrixLayout, int n, System.IntPtr a, int lda, double* s, double* scond, double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zporfs")]
            internal static extern int Zporfs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zporfs_work")]
            internal static extern int ZporfsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* ferr, double* berr, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zporfsx")]
            internal static extern int Zporfsx(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte equed, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, double* s, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* rcond, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zporfsx_work")]
            internal static extern int ZporfsxWork(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte equed, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, double* s, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* rcond, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zposv")]
            internal static extern int Zposv(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zposv_work")]
            internal static extern int ZposvWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zposvx")]
            internal static extern int Zposvx(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, sbyte* equed, double* s, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* rcond, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zposvx_work")]
            internal static extern int ZposvxWork(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, sbyte* equed, double* s, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* rcond, double* ferr, double* berr, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zposvxx")]
            internal static extern int Zposvxx(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, sbyte* equed, double* s, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* rcond, double* rpvgrw, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zposvxx_work")]
            internal static extern int ZposvxxWork(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, sbyte* equed, double* s, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* rcond, double* rpvgrw, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zpotrf")]
            internal static extern int Zpotrf(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zpotrf2")]
            internal static extern int Zpotrf2(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zpotrf2_work")]
            internal static extern int Zpotrf2Work(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zpotrf_work")]
            internal static extern int ZpotrfWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zpotri")]
            internal static extern int Zpotri(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zpotri_work")]
            internal static extern int ZpotriWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zpotrs")]
            internal static extern int Zpotrs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zpotrs_work")]
            internal static extern int ZpotrsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zppcon")]
            internal static extern int Zppcon(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zppcon_work")]
            internal static extern int ZppconWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, double anorm, double* rcond, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zppequ")]
            internal static extern int Zppequ(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, double* s, double* scond, double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zppequ_work")]
            internal static extern int ZppequWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, double* s, double* scond, double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zpprfs")]
            internal static extern int Zpprfs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr ap, System.IntPtr afp, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zpprfs_work")]
            internal static extern int ZpprfsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr ap, System.IntPtr afp, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* ferr, double* berr, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zppsv")]
            internal static extern int Zppsv(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr ap, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zppsv_work")]
            internal static extern int ZppsvWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr ap, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zppsvx")]
            internal static extern int Zppsvx(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, System.IntPtr ap, System.IntPtr afp, sbyte* equed, double* s, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* rcond, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zppsvx_work")]
            internal static extern int ZppsvxWork(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, System.IntPtr ap, System.IntPtr afp, sbyte* equed, double* s, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* rcond, double* ferr, double* berr, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zpptrf")]
            internal static extern int Zpptrf(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zpptrf_work")]
            internal static extern int ZpptrfWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zpptri")]
            internal static extern int Zpptri(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zpptri_work")]
            internal static extern int ZpptriWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zpptrs")]
            internal static extern int Zpptrs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr ap, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zpptrs_work")]
            internal static extern int ZpptrsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr ap, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zpstrf")]
            internal static extern int Zpstrf(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* piv, int* rank, double tol);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zpstrf_work")]
            internal static extern int ZpstrfWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* piv, int* rank, double tol, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zptcon")]
            internal static extern int Zptcon(int n, double* d, System.IntPtr e, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zptcon_work")]
            internal static extern int ZptconWork(int n, double* d, System.IntPtr e, double anorm, double* rcond, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zpteqr")]
            internal static extern int Zpteqr(BLAS.LAYOUT matrixLayout, sbyte compz, int n, double* d, double* e, System.IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zpteqr_work")]
            internal static extern int ZpteqrWork(BLAS.LAYOUT matrixLayout, sbyte compz, int n, double* d, double* e, System.IntPtr z, int ldz, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zptrfs")]
            internal static extern int Zptrfs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* d, System.IntPtr e, double* df, System.IntPtr ef, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zptrfs_work")]
            internal static extern int ZptrfsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* d, System.IntPtr e, double* df, System.IntPtr ef, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* ferr, double* berr, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zptsv")]
            internal static extern int Zptsv(BLAS.LAYOUT matrixLayout, int n, int nrhs, double* d, System.IntPtr e, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zptsv_work")]
            internal static extern int ZptsvWork(BLAS.LAYOUT matrixLayout, int n, int nrhs, double* d, System.IntPtr e, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zptsvx")]
            internal static extern int Zptsvx(BLAS.LAYOUT matrixLayout, sbyte fact, int n, int nrhs, double* d, System.IntPtr e, double* df, System.IntPtr ef, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* rcond, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zptsvx_work")]
            internal static extern int ZptsvxWork(BLAS.LAYOUT matrixLayout, sbyte fact, int n, int nrhs, double* d, System.IntPtr e, double* df, System.IntPtr ef, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* rcond, double* ferr, double* berr, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zpttrf")]
            internal static extern int Zpttrf(int n, double* d, System.IntPtr e);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zpttrf_work")]
            internal static extern int ZpttrfWork(int n, double* d, System.IntPtr e);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zpttrs")]
            internal static extern int Zpttrs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* d, System.IntPtr e, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zpttrs_work")]
            internal static extern int ZpttrsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* d, System.IntPtr e, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zspcon")]
            internal static extern int Zspcon(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, int* ipiv, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zspcon_work")]
            internal static extern int ZspconWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, int* ipiv, double anorm, double* rcond, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zsprfs")]
            internal static extern int Zsprfs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr ap, System.IntPtr afp, int* ipiv, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zsprfs_work")]
            internal static extern int ZsprfsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr ap, System.IntPtr afp, int* ipiv, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* ferr, double* berr, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zspsv")]
            internal static extern int Zspsv(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr ap, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zspsv_work")]
            internal static extern int ZspsvWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr ap, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zspsvx")]
            internal static extern int Zspsvx(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, System.IntPtr ap, System.IntPtr afp, int* ipiv, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* rcond, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zspsvx_work")]
            internal static extern int ZspsvxWork(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, System.IntPtr ap, System.IntPtr afp, int* ipiv, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* rcond, double* ferr, double* berr, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zsptrf")]
            internal static extern int Zsptrf(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zsptrf_work")]
            internal static extern int ZsptrfWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zsptri")]
            internal static extern int Zsptri(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zsptri_work")]
            internal static extern int ZsptriWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, int* ipiv, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zsptrs")]
            internal static extern int Zsptrs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr ap, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zsptrs_work")]
            internal static extern int ZsptrsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr ap, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zstedc")]
            internal static extern int Zstedc(BLAS.LAYOUT matrixLayout, sbyte compz, int n, double* d, double* e, System.IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zstedc_work")]
            internal static extern int ZstedcWork(BLAS.LAYOUT matrixLayout, sbyte compz, int n, double* d, double* e, System.IntPtr z, int ldz, System.IntPtr work, int lwork, double* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zstegr")]
            internal static extern int Zstegr(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, int n, double* d, double* e, double vl, double vu, int il, int iu, double abstol, int* m, double* w, System.IntPtr z, int ldz, int* isuppz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zstegr_work")]
            internal static extern int ZstegrWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, int n, double* d, double* e, double vl, double vu, int il, int iu, double abstol, int* m, double* w, System.IntPtr z, int ldz, int* isuppz, double* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zstein")]
            internal static extern int Zstein(BLAS.LAYOUT matrixLayout, int n, double* d, double* e, int m, double* w, int* iblock, int* isplit, System.IntPtr z, int ldz, int* ifailv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zstein_work")]
            internal static extern int ZsteinWork(BLAS.LAYOUT matrixLayout, int n, double* d, double* e, int m, double* w, int* iblock, int* isplit, System.IntPtr z, int ldz, double* work, int* iwork, int* ifailv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zstemr")]
            internal static extern int Zstemr(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, int n, double* d, double* e, double vl, double vu, int il, int iu, int* m, double* w, System.IntPtr z, int ldz, int nzc, int* isuppz, int* tryrac);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zstemr_work")]
            internal static extern int ZstemrWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, int n, double* d, double* e, double vl, double vu, int il, int iu, int* m, double* w, System.IntPtr z, int ldz, int nzc, int* isuppz, int* tryrac, double* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zsteqr")]
            internal static extern int Zsteqr(BLAS.LAYOUT matrixLayout, sbyte compz, int n, double* d, double* e, System.IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zsteqr_work")]
            internal static extern int ZsteqrWork(BLAS.LAYOUT matrixLayout, sbyte compz, int n, double* d, double* e, System.IntPtr z, int ldz, double* work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zsycon")]
            internal static extern int Zsycon(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zsycon_work")]
            internal static extern int ZsyconWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv, double anorm, double* rcond, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zsyconv")]
            internal static extern int Zsyconv(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte way, int n, System.IntPtr a, int lda, int* ipiv, System.IntPtr e);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zsyconv_work")]
            internal static extern int ZsyconvWork(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte way, int n, System.IntPtr a, int lda, int* ipiv, System.IntPtr e);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zsyequb")]
            internal static extern int Zsyequb(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, double* s, double* scond, double* amax);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zsyequb_work")]
            internal static extern int ZsyequbWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, double* s, double* scond, double* amax, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zsyr")]
            internal static extern int Zsyr(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr alpha, System.IntPtr x, int incx, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zsyr_work")]
            internal static extern int ZsyrWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr alpha, System.IntPtr x, int incx, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zsyrfs")]
            internal static extern int Zsyrfs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, int* ipiv, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zsyrfs_work")]
            internal static extern int ZsyrfsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, int* ipiv, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* ferr, double* berr, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zsyrfsx")]
            internal static extern int Zsyrfsx(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte equed, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, int* ipiv, double* s, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* rcond, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zsyrfsx_work")]
            internal static extern int ZsyrfsxWork(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte equed, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, int* ipiv, double* s, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* rcond, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zsysv")]
            internal static extern int Zsysv(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zsysv_rook")]
            internal static extern int ZsysvRook(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zsysv_rook_work")]
            internal static extern int ZsysvRookWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zsysv_work")]
            internal static extern int ZsysvWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zsysvx")]
            internal static extern int Zsysvx(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, int* ipiv, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* rcond, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zsysvx_work")]
            internal static extern int ZsysvxWork(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, int* ipiv, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* rcond, double* ferr, double* berr, System.IntPtr work, int lwork, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zsysvxx")]
            internal static extern int Zsysvxx(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, int* ipiv, sbyte* equed, double* s, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* rcond, double* rpvgrw, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zsysvxx_work")]
            internal static extern int ZsysvxxWork(BLAS.LAYOUT matrixLayout, sbyte fact, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr af, int ldaf, int* ipiv, sbyte* equed, double* s, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* rcond, double* rpvgrw, double* berr, int n_err_bnds, double* err_bnds_norm, double* err_bnds_comp, int nparams, double* @params, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zsyswapr")]
            internal static extern int Zsyswapr(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int i1, int i2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zsyswapr_work")]
            internal static extern int ZsyswaprWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int i1, int i2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zsytrf")]
            internal static extern int Zsytrf(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zsytrf_rook")]
            internal static extern int ZsytrfRook(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zsytrf_rook_work")]
            internal static extern int ZsytrfRookWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zsytrf_work")]
            internal static extern int ZsytrfWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zsytri")]
            internal static extern int Zsytri(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zsytri2")]
            internal static extern int Zsytri2(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zsytri2_work")]
            internal static extern int Zsytri2Work(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zsytri2x")]
            internal static extern int Zsytri2x(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv, int nb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zsytri2x_work")]
            internal static extern int Zsytri2xWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv, System.IntPtr work, int nb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zsytri_work")]
            internal static extern int ZsytriWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zsytrs")]
            internal static extern int Zsytrs(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zsytrs2")]
            internal static extern int Zsytrs2(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zsytrs2_work")]
            internal static extern int Zsytrs2Work(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zsytrs_rook")]
            internal static extern int ZsytrsRook(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zsytrs_rook_work")]
            internal static extern int ZsytrsRookWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zsytrs_work")]
            internal static extern int ZsytrsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ztbcon")]
            internal static extern int Ztbcon(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int n, int kd, System.IntPtr ab, int ldab, double* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ztbcon_work")]
            internal static extern int ZtbconWork(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int n, int kd, System.IntPtr ab, int ldab, double* rcond, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ztbrfs")]
            internal static extern int Ztbrfs(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int kd, int nrhs, System.IntPtr ab, int ldab, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ztbrfs_work")]
            internal static extern int ZtbrfsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int kd, int nrhs, System.IntPtr ab, int ldab, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* ferr, double* berr, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ztbtrs")]
            internal static extern int Ztbtrs(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int kd, int nrhs, System.IntPtr ab, int ldab, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ztbtrs_work")]
            internal static extern int ZtbtrsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int kd, int nrhs, System.IntPtr ab, int ldab, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ztfsm")]
            internal static extern int Ztfsm(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte side, sbyte uplo, BLAS.TRANS trans, sbyte diag, int m, int n, System.IntPtr alpha, System.IntPtr a, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ztfsm_work")]
            internal static extern int ZtfsmWork(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte side, sbyte uplo, BLAS.TRANS trans, sbyte diag, int m, int n, System.IntPtr alpha, System.IntPtr a, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ztftri")]
            internal static extern int Ztftri(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, sbyte diag, int n, System.IntPtr a);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ztftri_work")]
            internal static extern int ZtftriWork(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, sbyte diag, int n, System.IntPtr a);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ztfttp")]
            internal static extern int Ztfttp(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, System.IntPtr arf, System.IntPtr ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ztfttp_work")]
            internal static extern int ZtfttpWork(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, System.IntPtr arf, System.IntPtr ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ztfttr")]
            internal static extern int Ztfttr(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, System.IntPtr arf, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ztfttr_work")]
            internal static extern int ZtfttrWork(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, System.IntPtr arf, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ztgevc")]
            internal static extern int Ztgevc(BLAS.LAYOUT matrixLayout, sbyte side, sbyte howmny, int* select, int n, System.IntPtr s, int lds, System.IntPtr p, int ldp, System.IntPtr vl, int ldvl, System.IntPtr vr, int ldvr, int mm, int* m);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ztgevc_work")]
            internal static extern int ZtgevcWork(BLAS.LAYOUT matrixLayout, sbyte side, sbyte howmny, int* select, int n, System.IntPtr s, int lds, System.IntPtr p, int ldp, System.IntPtr vl, int ldvl, System.IntPtr vr, int ldvr, int mm, int* m, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ztgexc")]
            internal static extern int Ztgexc(BLAS.LAYOUT matrixLayout, int wantq, int wantz, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr q, int ldq, System.IntPtr z, int ldz, int ifst, int ilst);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ztgexc_work")]
            internal static extern int ZtgexcWork(BLAS.LAYOUT matrixLayout, int wantq, int wantz, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr q, int ldq, System.IntPtr z, int ldz, int ifst, int ilst);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ztgsen")]
            internal static extern int Ztgsen(BLAS.LAYOUT matrixLayout, int ijob, int wantq, int wantz, int* select, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr alpha, System.IntPtr beta, System.IntPtr q, int ldq, System.IntPtr z, int ldz, int* m, double* pl, double* pr, double* dif);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ztgsen_work")]
            internal static extern int ZtgsenWork(BLAS.LAYOUT matrixLayout, int ijob, int wantq, int wantz, int* select, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr alpha, System.IntPtr beta, System.IntPtr q, int ldq, System.IntPtr z, int ldz, int* m, double* pl, double* pr, double* dif, System.IntPtr work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ztgsja")]
            internal static extern int Ztgsja(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, int k, int l, System.IntPtr a, int lda, System.IntPtr b, int ldb, double tola, double tolb, double* alpha, double* beta, System.IntPtr u, int ldu, System.IntPtr v, int ldv, System.IntPtr q, int ldq, int* ncycle);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ztgsja_work")]
            internal static extern int ZtgsjaWork(BLAS.LAYOUT matrixLayout, sbyte jobu, sbyte jobv, sbyte jobq, int m, int p, int n, int k, int l, System.IntPtr a, int lda, System.IntPtr b, int ldb, double tola, double tolb, double* alpha, double* beta, System.IntPtr u, int ldu, System.IntPtr v, int ldv, System.IntPtr q, int ldq, System.IntPtr work, int* ncycle);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ztgsna")]
            internal static extern int Ztgsna(BLAS.LAYOUT matrixLayout, sbyte job, sbyte howmny, int* select, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr vl, int ldvl, System.IntPtr vr, int ldvr, double* s, double* dif, int mm, int* m);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ztgsna_work")]
            internal static extern int ZtgsnaWork(BLAS.LAYOUT matrixLayout, sbyte job, sbyte howmny, int* select, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr vl, int ldvl, System.IntPtr vr, int ldvr, double* s, double* dif, int mm, int* m, System.IntPtr work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ztgsyl")]
            internal static extern int Ztgsyl(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int ijob, int m, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr c, int ldc, System.IntPtr d, int ldd, System.IntPtr e, int lde, System.IntPtr f, int ldf, double* scale, double* dif);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ztgsyl_work")]
            internal static extern int ZtgsylWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int ijob, int m, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr c, int ldc, System.IntPtr d, int ldd, System.IntPtr e, int lde, System.IntPtr f, int ldf, double* scale, double* dif, System.IntPtr work, int lwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ztpcon")]
            internal static extern int Ztpcon(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int n, System.IntPtr ap, double* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ztpcon_work")]
            internal static extern int ZtpconWork(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int n, System.IntPtr ap, double* rcond, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ztpmqrt")]
            internal static extern int Ztpmqrt(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, int l, int nb, System.IntPtr v, int ldv, System.IntPtr t, int ldt, System.IntPtr a, int lda, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ztpmqrt_work")]
            internal static extern int ZtpmqrtWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, int l, int nb, System.IntPtr v, int ldv, System.IntPtr t, int ldt, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ztpqrt")]
            internal static extern int Ztpqrt(BLAS.LAYOUT matrixLayout, int m, int n, int l, int nb, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ztpqrt2")]
            internal static extern int Ztpqrt2(BLAS.LAYOUT matrixLayout, int m, int n, int l, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ztpqrt2_work")]
            internal static extern int Ztpqrt2Work(BLAS.LAYOUT matrixLayout, int m, int n, int l, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr t, int ldt);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ztpqrt_work")]
            internal static extern int ZtpqrtWork(BLAS.LAYOUT matrixLayout, int m, int n, int l, int nb, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr t, int ldt, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ztprfb")]
            internal static extern int Ztprfb(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, sbyte direct, sbyte storev, int m, int n, int k, int l, System.IntPtr v, int ldv, System.IntPtr t, int ldt, System.IntPtr a, int lda, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ztprfb_work")]
            internal static extern int ZtprfbWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, sbyte direct, sbyte storev, int m, int n, int k, int l, System.IntPtr v, int ldv, System.IntPtr t, int ldt, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr work, int ldwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ztprfs")]
            internal static extern int Ztprfs(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, System.IntPtr ap, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ztprfs_work")]
            internal static extern int ZtprfsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, System.IntPtr ap, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* ferr, double* berr, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ztptri")]
            internal static extern int Ztptri(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte diag, int n, System.IntPtr ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ztptri_work")]
            internal static extern int ZtptriWork(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte diag, int n, System.IntPtr ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ztptrs")]
            internal static extern int Ztptrs(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, System.IntPtr ap, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ztptrs_work")]
            internal static extern int ZtptrsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, System.IntPtr ap, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ztpttf")]
            internal static extern int Ztpttf(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, System.IntPtr ap, System.IntPtr arf);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ztpttf_work")]
            internal static extern int ZtpttfWork(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, System.IntPtr ap, System.IntPtr arf);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ztpttr")]
            internal static extern int Ztpttr(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ztpttr_work")]
            internal static extern int ZtpttrWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ztrcon")]
            internal static extern int Ztrcon(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int n, System.IntPtr a, int lda, double* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ztrcon_work")]
            internal static extern int ZtrconWork(BLAS.LAYOUT matrixLayout, sbyte norm, sbyte uplo, sbyte diag, int n, System.IntPtr a, int lda, double* rcond, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ztrevc")]
            internal static extern int Ztrevc(BLAS.LAYOUT matrixLayout, sbyte side, sbyte howmny, int* select, int n, System.IntPtr t, int ldt, System.IntPtr vl, int ldvl, System.IntPtr vr, int ldvr, int mm, int* m);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ztrevc_work")]
            internal static extern int ZtrevcWork(BLAS.LAYOUT matrixLayout, sbyte side, sbyte howmny, int* select, int n, System.IntPtr t, int ldt, System.IntPtr vl, int ldvl, System.IntPtr vr, int ldvr, int mm, int* m, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ztrexc")]
            internal static extern int Ztrexc(BLAS.LAYOUT matrixLayout, sbyte compq, int n, System.IntPtr t, int ldt, System.IntPtr q, int ldq, int ifst, int ilst);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ztrexc_work")]
            internal static extern int ZtrexcWork(BLAS.LAYOUT matrixLayout, sbyte compq, int n, System.IntPtr t, int ldt, System.IntPtr q, int ldq, int ifst, int ilst);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ztrrfs")]
            internal static extern int Ztrrfs(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* ferr, double* berr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ztrrfs_work")]
            internal static extern int ZtrrfsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr x, int ldx, double* ferr, double* berr, System.IntPtr work, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ztrsen")]
            internal static extern int Ztrsen(BLAS.LAYOUT matrixLayout, sbyte job, sbyte compq, int* select, int n, System.IntPtr t, int ldt, System.IntPtr q, int ldq, System.IntPtr w, int* m, double* s, double* sep);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ztrsen_work")]
            internal static extern int ZtrsenWork(BLAS.LAYOUT matrixLayout, sbyte job, sbyte compq, int* select, int n, System.IntPtr t, int ldt, System.IntPtr q, int ldq, System.IntPtr w, int* m, double* s, double* sep, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ztrsna")]
            internal static extern int Ztrsna(BLAS.LAYOUT matrixLayout, sbyte job, sbyte howmny, int* select, int n, System.IntPtr t, int ldt, System.IntPtr vl, int ldvl, System.IntPtr vr, int ldvr, double* s, double* sep, int mm, int* m);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ztrsna_work")]
            internal static extern int ZtrsnaWork(BLAS.LAYOUT matrixLayout, sbyte job, sbyte howmny, int* select, int n, System.IntPtr t, int ldt, System.IntPtr vl, int ldvl, System.IntPtr vr, int ldvr, double* s, double* sep, int mm, int* m, System.IntPtr work, int ldwork, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ztrsyl")]
            internal static extern int Ztrsyl(BLAS.LAYOUT matrixLayout, sbyte trana, sbyte tranb, int isgn, int m, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr c, int ldc, double* scale);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ztrsyl_work")]
            internal static extern int ZtrsylWork(BLAS.LAYOUT matrixLayout, sbyte trana, sbyte tranb, int isgn, int m, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr c, int ldc, double* scale);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ztrtri")]
            internal static extern int Ztrtri(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte diag, int n, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ztrtri_work")]
            internal static extern int ZtrtriWork(BLAS.LAYOUT matrixLayout, sbyte uplo, sbyte diag, int n, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ztrtrs")]
            internal static extern int Ztrtrs(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ztrtrs_work")]
            internal static extern int ZtrtrsWork(BLAS.LAYOUT matrixLayout, sbyte uplo, BLAS.TRANS trans, sbyte diag, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ztrttf")]
            internal static extern int Ztrttf(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr arf);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ztrttf_work")]
            internal static extern int ZtrttfWork(BLAS.LAYOUT matrixLayout, sbyte transr, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr arf);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ztrttp")]
            internal static extern int Ztrttp(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ztrttp_work")]
            internal static extern int ZtrttpWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr ap);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ztzrzf")]
            internal static extern int Ztzrzf(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ztzrzf_work")]
            internal static extern int ZtzrzfWork(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zunbdb")]
            internal static extern int Zunbdb(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, sbyte signs, int m, int p, int q, System.IntPtr x11, int ldx11, System.IntPtr x12, int ldx12, System.IntPtr x21, int ldx21, System.IntPtr x22, int ldx22, double* theta, double* phi, System.IntPtr taup1, System.IntPtr taup2, System.IntPtr tauq1, System.IntPtr tauq2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zunbdb_work")]
            internal static extern int ZunbdbWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, sbyte signs, int m, int p, int q, System.IntPtr x11, int ldx11, System.IntPtr x12, int ldx12, System.IntPtr x21, int ldx21, System.IntPtr x22, int ldx22, double* theta, double* phi, System.IntPtr taup1, System.IntPtr taup2, System.IntPtr tauq1, System.IntPtr tauq2, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zuncsd")]
            internal static extern int Zuncsd(BLAS.LAYOUT matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, sbyte jobv2t, BLAS.TRANS trans, sbyte signs, int m, int p, int q, System.IntPtr x11, int ldx11, System.IntPtr x12, int ldx12, System.IntPtr x21, int ldx21, System.IntPtr x22, int ldx22, double* theta, System.IntPtr u1, int ldu1, System.IntPtr u2, int ldu2, System.IntPtr v1t, int ldv1t, System.IntPtr v2t, int ldv2t);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zuncsd2by1")]
            internal static extern int Zuncsd2by1(BLAS.LAYOUT matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, int m, int p, int q, System.IntPtr x11, int ldx11, System.IntPtr x21, int ldx21, double* theta, System.IntPtr u1, int ldu1, System.IntPtr u2, int ldu2, System.IntPtr v1t, int ldv1t);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zuncsd2by1_work")]
            internal static extern int Zuncsd2by1Work(BLAS.LAYOUT matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, int m, int p, int q, System.IntPtr x11, int ldx11, System.IntPtr x21, int ldx21, double* theta, System.IntPtr u1, int ldu1, System.IntPtr u2, int ldu2, System.IntPtr v1t, int ldv1t, System.IntPtr work, int lwork, double* rwork, int lrwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zuncsd_work")]
            internal static extern int ZuncsdWork(BLAS.LAYOUT matrixLayout, sbyte jobu1, sbyte jobu2, sbyte jobv1t, sbyte jobv2t, BLAS.TRANS trans, sbyte signs, int m, int p, int q, System.IntPtr x11, int ldx11, System.IntPtr x12, int ldx12, System.IntPtr x21, int ldx21, System.IntPtr x22, int ldx22, double* theta, System.IntPtr u1, int ldu1, System.IntPtr u2, int ldu2, System.IntPtr v1t, int ldv1t, System.IntPtr v2t, int ldv2t, System.IntPtr work, int lwork, double* rwork, int lrwork, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zungbr")]
            internal static extern int Zungbr(BLAS.LAYOUT matrixLayout, sbyte vect, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zungbr_work")]
            internal static extern int ZungbrWork(BLAS.LAYOUT matrixLayout, sbyte vect, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zunghr")]
            internal static extern int Zunghr(BLAS.LAYOUT matrixLayout, int n, int ilo, int ihi, System.IntPtr a, int lda, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zunghr_work")]
            internal static extern int ZunghrWork(BLAS.LAYOUT matrixLayout, int n, int ilo, int ihi, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zunglq")]
            internal static extern int Zunglq(BLAS.LAYOUT matrixLayout, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zunglq_work")]
            internal static extern int ZunglqWork(BLAS.LAYOUT matrixLayout, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zungql")]
            internal static extern int Zungql(BLAS.LAYOUT matrixLayout, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zungql_work")]
            internal static extern int ZungqlWork(BLAS.LAYOUT matrixLayout, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zungqr")]
            internal static extern int Zungqr(BLAS.LAYOUT matrixLayout, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zungqr_work")]
            internal static extern int ZungqrWork(BLAS.LAYOUT matrixLayout, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zungrq")]
            internal static extern int Zungrq(BLAS.LAYOUT matrixLayout, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zungrq_work")]
            internal static extern int ZungrqWork(BLAS.LAYOUT matrixLayout, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zungtr")]
            internal static extern int Zungtr(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr tau);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zungtr_work")]
            internal static extern int ZungtrWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zunmbr")]
            internal static extern int Zunmbr(BLAS.LAYOUT matrixLayout, sbyte vect, sbyte side, BLAS.TRANS trans, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zunmbr_work")]
            internal static extern int ZunmbrWork(BLAS.LAYOUT matrixLayout, sbyte vect, sbyte side, BLAS.TRANS trans, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr c, int ldc, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zunmhr")]
            internal static extern int Zunmhr(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int ilo, int ihi, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zunmhr_work")]
            internal static extern int ZunmhrWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int ilo, int ihi, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr c, int ldc, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zunmlq")]
            internal static extern int Zunmlq(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zunmlq_work")]
            internal static extern int ZunmlqWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr c, int ldc, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zunmql")]
            internal static extern int Zunmql(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zunmql_work")]
            internal static extern int ZunmqlWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr c, int ldc, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zunmqr")]
            internal static extern int Zunmqr(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zunmqr_work")]
            internal static extern int ZunmqrWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr c, int ldc, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zunmrq")]
            internal static extern int Zunmrq(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zunmrq_work")]
            internal static extern int ZunmrqWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr c, int ldc, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zunmrz")]
            internal static extern int Zunmrz(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, int l, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zunmrz_work")]
            internal static extern int ZunmrzWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, int l, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr c, int ldc, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zunmtr")]
            internal static extern int Zunmtr(BLAS.LAYOUT matrixLayout, sbyte side, sbyte uplo, BLAS.TRANS trans, int m, int n, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zunmtr_work")]
            internal static extern int ZunmtrWork(BLAS.LAYOUT matrixLayout, sbyte side, sbyte uplo, BLAS.TRANS trans, int m, int n, System.IntPtr a, int lda, System.IntPtr tau, System.IntPtr c, int ldc, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zupgtr")]
            internal static extern int Zupgtr(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, System.IntPtr tau, System.IntPtr q, int ldq);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zupgtr_work")]
            internal static extern int ZupgtrWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr ap, System.IntPtr tau, System.IntPtr q, int ldq, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zupmtr")]
            internal static extern int Zupmtr(BLAS.LAYOUT matrixLayout, sbyte side, sbyte uplo, BLAS.TRANS trans, int m, int n, System.IntPtr ap, System.IntPtr tau, System.IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zupmtr_work")]
            internal static extern int ZupmtrWork(BLAS.LAYOUT matrixLayout, sbyte side, sbyte uplo, BLAS.TRANS trans, int m, int n, System.IntPtr ap, System.IntPtr tau, System.IntPtr c, int ldc, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ilaver")]
            internal static extern void Ilaver(int* vers_major, int* vers_minor, int* vers_patch);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chesv_aa")]
            internal static extern int ChesvAa(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chesv_aa_work")]
            internal static extern int ChesvAaWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chetrf_aa")]
            internal static extern int ChetrfAa(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chetrf_aa_work")]
            internal static extern int ChetrfAaWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chetrs_aa")]
            internal static extern int ChetrsAa(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chetrs_aa_work")]
            internal static extern int ChetrsAaWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsysv_aa")]
            internal static extern int DsysvAa(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsysv_aa_work")]
            internal static extern int DsysvAaWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsytrf_aa")]
            internal static extern int DsytrfAa(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsytrf_aa_work")]
            internal static extern int DsytrfAaWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda, int* ipiv, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsytrs_aa")]
            internal static extern int DsytrsAa(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsytrs_aa_work")]
            internal static extern int DsytrsAaWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, int* ipiv, double* b, int ldb, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssysv_aa")]
            internal static extern int SsysvAa(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssysv_aa_work")]
            internal static extern int SsysvAaWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssytrf_aa")]
            internal static extern int SsytrfAa(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssytrf_aa_work")]
            internal static extern int SsytrfAaWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda, int* ipiv, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssytrs_aa")]
            internal static extern int SsytrsAa(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssytrs_aa_work")]
            internal static extern int SsytrsAaWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, int* ipiv, float* b, int ldb, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhesv_aa")]
            internal static extern int ZhesvAa(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhesv_aa_work")]
            internal static extern int ZhesvAaWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhetrf_aa")]
            internal static extern int ZhetrfAa(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhetrf_aa_work")]
            internal static extern int ZhetrfAaWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhetrs_aa")]
            internal static extern int ZhetrsAa(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhetrs_aa_work")]
            internal static extern int ZhetrsAaWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgemqr")]
            internal static extern int Cgemqr(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr t, int tsize, System.IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgemqr_work")]
            internal static extern int CgemqrWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr t, int tsize, System.IntPtr c, int ldc, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgeqr")]
            internal static extern int Cgeqr(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr t, int tsize);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgeqr_work")]
            internal static extern int CgeqrWork(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr t, int tsize, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgemqr")]
            internal static extern int Dgemqr(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, double* a, int lda, double* t, int tsize, double* c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgemqr_work")]
            internal static extern int DgemqrWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, double* a, int lda, double* t, int tsize, double* c, int ldc, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgeqr")]
            internal static extern int Dgeqr(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, double* t, int tsize);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgeqr_work")]
            internal static extern int DgeqrWork(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, double* t, int tsize, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgemqr")]
            internal static extern int Sgemqr(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, float* a, int lda, float* t, int tsize, float* c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgemqr_work")]
            internal static extern int SgemqrWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, float* a, int lda, float* t, int tsize, float* c, int ldc, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgeqr")]
            internal static extern int Sgeqr(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda, float* t, int tsize);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgeqr_work")]
            internal static extern int SgeqrWork(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda, float* t, int tsize, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgemqr")]
            internal static extern int Zgemqr(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr t, int tsize, System.IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgemqr_work")]
            internal static extern int ZgemqrWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr t, int tsize, System.IntPtr c, int ldc, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgeqr")]
            internal static extern int Zgeqr(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr t, int tsize);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgeqr_work")]
            internal static extern int ZgeqrWork(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr t, int tsize, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgelq")]
            internal static extern int Cgelq(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr t, int tsize);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgelq_work")]
            internal static extern int CgelqWork(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr t, int tsize, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgemlq")]
            internal static extern int Cgemlq(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr t, int tsize, System.IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgemlq_work")]
            internal static extern int CgemlqWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr t, int tsize, System.IntPtr c, int ldc, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgelq")]
            internal static extern int Dgelq(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, double* t, int tsize);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgelq_work")]
            internal static extern int DgelqWork(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda, double* t, int tsize, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgemlq")]
            internal static extern int Dgemlq(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, double* a, int lda, double* t, int tsize, double* c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgemlq_work")]
            internal static extern int DgemlqWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, double* a, int lda, double* t, int tsize, double* c, int ldc, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgelq")]
            internal static extern int Sgelq(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda, float* t, int tsize);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgelq_work")]
            internal static extern int SgelqWork(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda, float* t, int tsize, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgemlq")]
            internal static extern int Sgemlq(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, float* a, int lda, float* t, int tsize, float* c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgemlq_work")]
            internal static extern int SgemlqWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, float* a, int lda, float* t, int tsize, float* c, int ldc, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgelq")]
            internal static extern int Zgelq(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr t, int tsize);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgelq_work")]
            internal static extern int ZgelqWork(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda, System.IntPtr t, int tsize, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgemlq")]
            internal static extern int Zgemlq(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr t, int tsize, System.IntPtr c, int ldc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgemlq_work")]
            internal static extern int ZgemlqWork(BLAS.LAYOUT matrixLayout, sbyte side, BLAS.TRANS trans, int m, int n, int k, System.IntPtr a, int lda, System.IntPtr t, int tsize, System.IntPtr c, int ldc, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgetsls")]
            internal static extern int Cgetsls(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int m, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cgetsls_work")]
            internal static extern int CgetslsWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int m, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgetsls")]
            internal static extern int Dgetsls(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int m, int n, int nrhs, double* a, int lda, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dgetsls_work")]
            internal static extern int DgetslsWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int m, int n, int nrhs, double* a, int lda, double* b, int ldb, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgetsls")]
            internal static extern int Sgetsls(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int m, int n, int nrhs, float* a, int lda, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_sgetsls_work")]
            internal static extern int SgetslsWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int m, int n, int nrhs, float* a, int lda, float* b, int ldb, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgetsls")]
            internal static extern int Zgetsls(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int m, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zgetsls_work")]
            internal static extern int ZgetslsWork(BLAS.LAYOUT matrixLayout, BLAS.TRANS trans, int m, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr b, int ldb, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_checon_3")]
            internal static extern int Checon3(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr e, int* ipiv, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_checon_3_work")]
            internal static extern int Checon3Work(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr e, int* ipiv, float anorm, float* rcond, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chesv_rk")]
            internal static extern int ChesvRk(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr e, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chesv_rk_work")]
            internal static extern int ChesvRkWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr e, int* ipiv, System.IntPtr b, int ldb, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chetrf_rk")]
            internal static extern int ChetrfRk(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr e, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chetrf_rk_work")]
            internal static extern int ChetrfRkWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr e, int* ipiv, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chetri_3")]
            internal static extern int Chetri3(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr e, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chetri_3_work")]
            internal static extern int Chetri3Work(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr e, int* ipiv, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chetrs_3")]
            internal static extern int Chetrs3(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr e, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chetrs_3_work")]
            internal static extern int Chetrs3Work(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr e, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_csycon_3")]
            internal static extern int Csycon3(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr e, int* ipiv, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_csycon_3_work")]
            internal static extern int Csycon3Work(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr e, int* ipiv, float anorm, float* rcond, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_csysv_aa")]
            internal static extern int CsysvAa(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_csysv_aa_work")]
            internal static extern int CsysvAaWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_csysv_rk")]
            internal static extern int CsysvRk(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr e, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_csysv_rk_work")]
            internal static extern int CsysvRkWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr e, int* ipiv, System.IntPtr b, int ldb, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_csytrf_aa")]
            internal static extern int CsytrfAa(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_csytrf_aa_work")]
            internal static extern int CsytrfAaWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_csytrf_rk")]
            internal static extern int CsytrfRk(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr e, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_csytrf_rk_work")]
            internal static extern int CsytrfRkWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr e, int* ipiv, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_csytri_3")]
            internal static extern int Csytri3(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr e, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_csytri_3_work")]
            internal static extern int Csytri3Work(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr e, int* ipiv, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_csytrs_3")]
            internal static extern int Csytrs3(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr e, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_csytrs_3_work")]
            internal static extern int Csytrs3Work(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr e, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_csytrs_aa")]
            internal static extern int CsytrsAa(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_csytrs_aa_work")]
            internal static extern int CsytrsAaWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsycon_3")]
            internal static extern int Dsycon3(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda, double* e, int* ipiv, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsycon_3_work")]
            internal static extern int Dsycon3Work(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda, double* e, int* ipiv, double anorm, double* rcond, double* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsysv_rk")]
            internal static extern int DsysvRk(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, double* e, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsysv_rk_work")]
            internal static extern int DsysvRkWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, double* e, int* ipiv, double* b, int ldb, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsytrf_rk")]
            internal static extern int DsytrfRk(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda, double* e, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsytrf_rk_work")]
            internal static extern int DsytrfRkWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda, double* e, int* ipiv, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsytri_3")]
            internal static extern int Dsytri3(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda, double* e, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsytri_3_work")]
            internal static extern int Dsytri3Work(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda, double* e, int* ipiv, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsytrs_3")]
            internal static extern int Dsytrs3(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, double* e, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsytrs_3_work")]
            internal static extern int Dsytrs3Work(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, double* e, int* ipiv, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssycon_3")]
            internal static extern int Ssycon3(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda, float* e, int* ipiv, float anorm, float* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssycon_3_work")]
            internal static extern int Ssycon3Work(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda, float* e, int* ipiv, float anorm, float* rcond, float* work, int* iwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssysv_rk")]
            internal static extern int SsysvRk(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, float* e, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssysv_rk_work")]
            internal static extern int SsysvRkWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, float* e, int* ipiv, float* b, int ldb, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssytrf_rk")]
            internal static extern int SsytrfRk(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda, float* e, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssytrf_rk_work")]
            internal static extern int SsytrfRkWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda, float* e, int* ipiv, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssytri_3")]
            internal static extern int Ssytri3(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda, float* e, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssytri_3_work")]
            internal static extern int Ssytri3Work(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda, float* e, int* ipiv, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssytrs_3")]
            internal static extern int Ssytrs3(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, float* e, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssytrs_3_work")]
            internal static extern int Ssytrs3Work(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, float* e, int* ipiv, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhecon_3")]
            internal static extern int Zhecon3(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr e, int* ipiv, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhecon_3_work")]
            internal static extern int Zhecon3Work(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr e, int* ipiv, double anorm, double* rcond, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhesv_rk")]
            internal static extern int ZhesvRk(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr e, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhesv_rk_work")]
            internal static extern int ZhesvRkWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr e, int* ipiv, System.IntPtr b, int ldb, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhetrf_rk")]
            internal static extern int ZhetrfRk(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr e, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhetrf_rk_work")]
            internal static extern int ZhetrfRkWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr e, int* ipiv, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhetri_3")]
            internal static extern int Zhetri3(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr e, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhetri_3_work")]
            internal static extern int Zhetri3Work(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr e, int* ipiv, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhetrs_3")]
            internal static extern int Zhetrs3(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr e, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhetrs_3_work")]
            internal static extern int Zhetrs3Work(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr e, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zsycon_3")]
            internal static extern int Zsycon3(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr e, int* ipiv, double anorm, double* rcond);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zsycon_3_work")]
            internal static extern int Zsycon3Work(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr e, int* ipiv, double anorm, double* rcond, System.IntPtr work);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zsysv_aa")]
            internal static extern int ZsysvAa(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zsysv_aa_work")]
            internal static extern int ZsysvAaWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zsysv_rk")]
            internal static extern int ZsysvRk(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr e, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zsysv_rk_work")]
            internal static extern int ZsysvRkWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr e, int* ipiv, System.IntPtr b, int ldb, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zsytrf_aa")]
            internal static extern int ZsytrfAa(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zsytrf_aa_work")]
            internal static extern int ZsytrfAaWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, int* ipiv, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zsytrf_rk")]
            internal static extern int ZsytrfRk(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr e, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zsytrf_rk_work")]
            internal static extern int ZsytrfRkWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr e, int* ipiv, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zsytri_3")]
            internal static extern int Zsytri3(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr e, int* ipiv);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zsytri_3_work")]
            internal static extern int Zsytri3Work(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr e, int* ipiv, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zsytrs_3")]
            internal static extern int Zsytrs3(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr e, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zsytrs_3_work")]
            internal static extern int Zsytrs3Work(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr e, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zsytrs_aa")]
            internal static extern int ZsytrsAa(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zsytrs_aa_work")]
            internal static extern int ZsytrsAaWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, int* ipiv, System.IntPtr b, int ldb, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chbev_2stage")]
            internal static extern int Chbev2stage(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, System.IntPtr ab, int ldab, float* w, System.IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chbev_2stage_work")]
            internal static extern int Chbev2stageWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, System.IntPtr ab, int ldab, float* w, System.IntPtr z, int ldz, System.IntPtr work, int lwork, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chbevd_2stage")]
            internal static extern int Chbevd2stage(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, System.IntPtr ab, int ldab, float* w, System.IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chbevd_2stage_work")]
            internal static extern int Chbevd2stageWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, System.IntPtr ab, int ldab, float* w, System.IntPtr z, int ldz, System.IntPtr work, int lwork, float* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chbevx_2stage")]
            internal static extern int Chbevx2stage(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, int kd, System.IntPtr ab, int ldab, System.IntPtr q, int ldq, float vl, float vu, int il, int iu, float abstol, int* m, float* w, System.IntPtr z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chbevx_2stage_work")]
            internal static extern int Chbevx2stageWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, int kd, System.IntPtr ab, int ldab, System.IntPtr q, int ldq, float vl, float vu, int il, int iu, float abstol, int* m, float* w, System.IntPtr z, int ldz, System.IntPtr work, int lwork, float* rwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cheev_2stage")]
            internal static extern int Cheev2stage(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, System.IntPtr a, int lda, float* w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cheev_2stage_work")]
            internal static extern int Cheev2stageWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, System.IntPtr a, int lda, float* w, System.IntPtr work, int lwork, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cheevd_2stage")]
            internal static extern int Cheevd2stage(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, System.IntPtr a, int lda, float* w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cheevd_2stage_work")]
            internal static extern int Cheevd2stageWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, System.IntPtr a, int lda, float* w, System.IntPtr work, int lwork, float* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cheevr_2stage")]
            internal static extern int Cheevr2stage(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, System.IntPtr a, int lda, float vl, float vu, int il, int iu, float abstol, int* m, float* w, System.IntPtr z, int ldz, int* isuppz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cheevr_2stage_work")]
            internal static extern int Cheevr2stageWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, System.IntPtr a, int lda, float vl, float vu, int il, int iu, float abstol, int* m, float* w, System.IntPtr z, int ldz, int* isuppz, System.IntPtr work, int lwork, float* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cheevx_2stage")]
            internal static extern int Cheevx2stage(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, System.IntPtr a, int lda, float vl, float vu, int il, int iu, float abstol, int* m, float* w, System.IntPtr z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_cheevx_2stage_work")]
            internal static extern int Cheevx2stageWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, System.IntPtr a, int lda, float vl, float vu, int il, int iu, float abstol, int* m, float* w, System.IntPtr z, int ldz, System.IntPtr work, int lwork, float* rwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chegv_2stage")]
            internal static extern int Chegv2stage(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, float* w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chegv_2stage_work")]
            internal static extern int Chegv2stageWork(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, float* w, System.IntPtr work, int lwork, float* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsbev_2stage")]
            internal static extern int Dsbev2stage(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, double* ab, int ldab, double* w, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsbev_2stage_work")]
            internal static extern int Dsbev2stageWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, double* ab, int ldab, double* w, double* z, int ldz, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsbevd_2stage")]
            internal static extern int Dsbevd2stage(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, double* ab, int ldab, double* w, double* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsbevd_2stage_work")]
            internal static extern int Dsbevd2stageWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, double* ab, int ldab, double* w, double* z, int ldz, double* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsbevx_2stage")]
            internal static extern int Dsbevx2stage(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, int kd, double* ab, int ldab, double* q, int ldq, double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsbevx_2stage_work")]
            internal static extern int Dsbevx2stageWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, int kd, double* ab, int ldab, double* q, int ldq, double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, double* work, int lwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsyev_2stage")]
            internal static extern int Dsyev2stage(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, double* a, int lda, double* w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsyev_2stage_work")]
            internal static extern int Dsyev2stageWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, double* a, int lda, double* w, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsyevd_2stage")]
            internal static extern int Dsyevd2stage(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, double* a, int lda, double* w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsyevd_2stage_work")]
            internal static extern int Dsyevd2stageWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, double* a, int lda, double* w, double* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsyevr_2stage")]
            internal static extern int Dsyevr2stage(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, double* a, int lda, double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, int* isuppz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsyevr_2stage_work")]
            internal static extern int Dsyevr2stageWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, double* a, int lda, double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, int* isuppz, double* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsyevx_2stage")]
            internal static extern int Dsyevx2stage(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, double* a, int lda, double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsyevx_2stage_work")]
            internal static extern int Dsyevx2stageWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, double* a, int lda, double vl, double vu, int il, int iu, double abstol, int* m, double* w, double* z, int ldz, double* work, int lwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsygv_2stage")]
            internal static extern int Dsygv2stage(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, double* a, int lda, double* b, int ldb, double* w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsygv_2stage_work")]
            internal static extern int Dsygv2stageWork(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, double* a, int lda, double* b, int ldb, double* w, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssbev_2stage")]
            internal static extern int Ssbev2stage(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, float* ab, int ldab, float* w, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssbev_2stage_work")]
            internal static extern int Ssbev2stageWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, float* ab, int ldab, float* w, float* z, int ldz, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssbevd_2stage")]
            internal static extern int Ssbevd2stage(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, float* ab, int ldab, float* w, float* z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssbevd_2stage_work")]
            internal static extern int Ssbevd2stageWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, float* ab, int ldab, float* w, float* z, int ldz, float* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssbevx_2stage")]
            internal static extern int Ssbevx2stage(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, int kd, float* ab, int ldab, float* q, int ldq, float vl, float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssbevx_2stage_work")]
            internal static extern int Ssbevx2stageWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, int kd, float* ab, int ldab, float* q, int ldq, float vl, float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, float* work, int lwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssyev_2stage")]
            internal static extern int Ssyev2stage(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, float* a, int lda, float* w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssyev_2stage_work")]
            internal static extern int Ssyev2stageWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, float* a, int lda, float* w, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssyevd_2stage")]
            internal static extern int Ssyevd2stage(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, float* a, int lda, float* w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssyevd_2stage_work")]
            internal static extern int Ssyevd2stageWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, float* a, int lda, float* w, float* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssyevr_2stage")]
            internal static extern int Ssyevr2stage(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, float* a, int lda, float vl, float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, int* isuppz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssyevr_2stage_work")]
            internal static extern int Ssyevr2stageWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, float* a, int lda, float vl, float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, int* isuppz, float* work, int lwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssyevx_2stage")]
            internal static extern int Ssyevx2stage(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, float* a, int lda, float vl, float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssyevx_2stage_work")]
            internal static extern int Ssyevx2stageWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, float* a, int lda, float vl, float vu, int il, int iu, float abstol, int* m, float* w, float* z, int ldz, float* work, int lwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssygv_2stage")]
            internal static extern int Ssygv2stage(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, float* a, int lda, float* b, int ldb, float* w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssygv_2stage_work")]
            internal static extern int Ssygv2stageWork(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, float* a, int lda, float* b, int ldb, float* w, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhbev_2stage")]
            internal static extern int Zhbev2stage(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, System.IntPtr ab, int ldab, double* w, System.IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhbev_2stage_work")]
            internal static extern int Zhbev2stageWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, System.IntPtr ab, int ldab, double* w, System.IntPtr z, int ldz, System.IntPtr work, int lwork, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhbevd_2stage")]
            internal static extern int Zhbevd2stage(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, System.IntPtr ab, int ldab, double* w, System.IntPtr z, int ldz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhbevd_2stage_work")]
            internal static extern int Zhbevd2stageWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, int kd, System.IntPtr ab, int ldab, double* w, System.IntPtr z, int ldz, System.IntPtr work, int lwork, double* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhbevx_2stage")]
            internal static extern int Zhbevx2stage(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, int kd, System.IntPtr ab, int ldab, System.IntPtr q, int ldq, double vl, double vu, int il, int iu, double abstol, int* m, double* w, System.IntPtr z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhbevx_2stage_work")]
            internal static extern int Zhbevx2stageWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, int kd, System.IntPtr ab, int ldab, System.IntPtr q, int ldq, double vl, double vu, int il, int iu, double abstol, int* m, double* w, System.IntPtr z, int ldz, System.IntPtr work, int lwork, double* rwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zheev_2stage")]
            internal static extern int Zheev2stage(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, System.IntPtr a, int lda, double* w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zheev_2stage_work")]
            internal static extern int Zheev2stageWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, System.IntPtr a, int lda, double* w, System.IntPtr work, int lwork, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zheevd_2stage")]
            internal static extern int Zheevd2stage(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, System.IntPtr a, int lda, double* w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zheevd_2stage_work")]
            internal static extern int Zheevd2stageWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte uplo, int n, System.IntPtr a, int lda, double* w, System.IntPtr work, int lwork, double* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zheevr_2stage")]
            internal static extern int Zheevr2stage(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, System.IntPtr a, int lda, double vl, double vu, int il, int iu, double abstol, int* m, double* w, System.IntPtr z, int ldz, int* isuppz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zheevr_2stage_work")]
            internal static extern int Zheevr2stageWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, System.IntPtr a, int lda, double vl, double vu, int il, int iu, double abstol, int* m, double* w, System.IntPtr z, int ldz, int* isuppz, System.IntPtr work, int lwork, double* rwork, int lrwork, int* iwork, int liwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zheevx_2stage")]
            internal static extern int Zheevx2stage(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, System.IntPtr a, int lda, double vl, double vu, int il, int iu, double abstol, int* m, double* w, System.IntPtr z, int ldz, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zheevx_2stage_work")]
            internal static extern int Zheevx2stageWork(BLAS.LAYOUT matrixLayout, sbyte jobz, sbyte range, sbyte uplo, int n, System.IntPtr a, int lda, double vl, double vu, int il, int iu, double abstol, int* m, double* w, System.IntPtr z, int ldz, System.IntPtr work, int lwork, double* rwork, int* iwork, int* ifail);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhegv_2stage")]
            internal static extern int Zhegv2stage(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, double* w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhegv_2stage_work")]
            internal static extern int Zhegv2stageWork(BLAS.LAYOUT matrixLayout, int itype, sbyte jobz, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr b, int ldb, double* w, System.IntPtr work, int lwork, double* rwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_mkl_cgetrfnp")]
            internal static extern int MklCgetrfnp(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_mkl_cgetrfnp_work")]
            internal static extern int MklCgetrfnpWork(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_mkl_dgetrfnp")]
            internal static extern int MklDgetrfnp(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_mkl_dgetrfnp_work")]
            internal static extern int MklDgetrfnpWork(BLAS.LAYOUT matrixLayout, int m, int n, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_mkl_sgetrfnp")]
            internal static extern int MklSgetrfnp(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_mkl_sgetrfnp_work")]
            internal static extern int MklSgetrfnpWork(BLAS.LAYOUT matrixLayout, int m, int n, float* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_mkl_zgetrfnp")]
            internal static extern int MklZgetrfnp(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_mkl_zgetrfnp_work")]
            internal static extern int MklZgetrfnpWork(BLAS.LAYOUT matrixLayout, int m, int n, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_mkl_cgetrinp")]
            internal static extern int MklCgetrinp(BLAS.LAYOUT matrixLayout, int n, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_mkl_cgetrinp_work")]
            internal static extern int MklCgetrinpWork(BLAS.LAYOUT matrixLayout, int n, System.IntPtr a, int lda, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_mkl_dgetrinp")]
            internal static extern int MklDgetrinp(BLAS.LAYOUT matrixLayout, int n, double* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_mkl_dgetrinp_work")]
            internal static extern int MklDgetrinpWork(BLAS.LAYOUT matrixLayout, int n, double* a, int lda, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_mkl_sgetrinp")]
            internal static extern int MklSgetrinp(BLAS.LAYOUT matrixLayout, int n, float* a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_mkl_sgetrinp_work")]
            internal static extern int MklSgetrinpWork(BLAS.LAYOUT matrixLayout, int n, float* a, int lda, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_mkl_zgetrinp")]
            internal static extern int MklZgetrinp(BLAS.LAYOUT matrixLayout, int n, System.IntPtr a, int lda);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_mkl_zgetrinp_work")]
            internal static extern int MklZgetrinpWork(BLAS.LAYOUT matrixLayout, int n, System.IntPtr a, int lda, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_set_nancheck")]
            internal static extern void SetNancheck(int flag);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_get_nancheck")]
            internal static extern int GetNancheck();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chesv_aa_2stage")]
            internal static extern int ChesvAa2stage(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr tb, int ltb, int* ipiv, int* ipiv2, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chetrf_aa_2stage")]
            internal static extern int ChetrfAa2stage(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr tb, int ltb, int* ipiv, int* ipiv2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chesv_aa_2stage_work")]
            internal static extern int ChesvAa2stageWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr tb, int ltb, int* ipiv, int* ipiv2, System.IntPtr b, int ldb, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chetrf_aa_2stage_work")]
            internal static extern int ChetrfAa2stageWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr tb, int ltb, int* ipiv, int* ipiv2, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chetrs_aa_2stage")]
            internal static extern int ChetrsAa2stage(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr tb, int ltb, int* ipiv, int* ipiv2, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_chetrs_aa_2stage_work")]
            internal static extern int ChetrsAa2stageWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr tb, int ltb, int* ipiv, int* ipiv2, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_csysv_aa_2stage")]
            internal static extern int CsysvAa2stage(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr tb, int ltb, int* ipiv, int* ipiv2, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_csysv_aa_2stage_work")]
            internal static extern int CsysvAa2stageWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr tb, int ltb, int* ipiv, int* ipiv2, System.IntPtr b, int ldb, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_csytrf_aa_2stage")]
            internal static extern int CsytrfAa2stage(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr tb, int ltb, int* ipiv, int* ipiv2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_csytrf_aa_2stage_work")]
            internal static extern int CsytrfAa2stageWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr tb, int ltb, int* ipiv, int* ipiv2, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_csytrs_aa_2stage")]
            internal static extern int CsytrsAa2stage(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr tb, int ltb, int* ipiv, int* ipiv2, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_csytrs_aa_2stage_work")]
            internal static extern int CsytrsAa2stageWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr tb, int ltb, int* ipiv, int* ipiv2, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsysv_aa_2stage")]
            internal static extern int DsysvAa2stage(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, double* tb, int ltb, int* ipiv, int* ipiv2, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsysv_aa_2stage_work")]
            internal static extern int DsysvAa2stageWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, double* tb, int ltb, int* ipiv, int* ipiv2, double* b, int ldb, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsytrf_aa_2stage")]
            internal static extern int DsytrfAa2stage(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda, double* tb, int ltb, int* ipiv, int* ipiv2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsytrf_aa_2stage_work")]
            internal static extern int DsytrfAa2stageWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, double* a, int lda, double* tb, int ltb, int* ipiv, int* ipiv2, double* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsytrs_aa_2stage")]
            internal static extern int DsytrsAa2stage(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, double* tb, int ltb, int* ipiv, int* ipiv2, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_dsytrs_aa_2stage_work")]
            internal static extern int DsytrsAa2stageWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, double* a, int lda, double* tb, int ltb, int* ipiv, int* ipiv2, double* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zsysv_aa_2stage")]
            internal static extern int ZsysvAa2stage(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr tb, int ltb, int* ipiv, int* ipiv2, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zsysv_aa_2stage_work")]
            internal static extern int ZsysvAa2stageWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr tb, int ltb, int* ipiv, int* ipiv2, System.IntPtr b, int ldb, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zsytrf_aa_2stage")]
            internal static extern int ZsytrfAa2stage(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr tb, int ltb, int* ipiv, int* ipiv2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zsytrf_aa_2stage_work")]
            internal static extern int ZsytrfAa2stageWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr tb, int ltb, int* ipiv, int* ipiv2, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zsytrs_aa_2stage")]
            internal static extern int ZsytrsAa2stage(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr tb, int ltb, int* ipiv, int* ipiv2, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zsytrs_aa_2stage_work")]
            internal static extern int ZsytrsAa2stageWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr tb, int ltb, int* ipiv, int* ipiv2, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssysv_aa_2stage")]
            internal static extern int SsysvAa2stage(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, float* tb, int ltb, int* ipiv, int* ipiv2, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssysv_aa_2stage_work")]
            internal static extern int SsysvAa2stageWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, float* tb, int ltb, int* ipiv, int* ipiv2, float* b, int ldb, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssytrf_aa_2stage")]
            internal static extern int SsytrfAa2stage(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda, float* tb, int ltb, int* ipiv, int* ipiv2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssytrf_aa_2stage_work")]
            internal static extern int SsytrfAa2stageWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, float* a, int lda, float* tb, int ltb, int* ipiv, int* ipiv2, float* work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssytrs_aa_2stage")]
            internal static extern int SsytrsAa2stage(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, float* tb, int ltb, int* ipiv, int* ipiv2, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_ssytrs_aa_2stage_work")]
            internal static extern int SsytrsAa2stageWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, float* a, int lda, float* tb, int ltb, int* ipiv, int* ipiv2, float* b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhesv_aa_2stage")]
            internal static extern int ZhesvAa2stage(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr tb, int ltb, int* ipiv, int* ipiv2, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhesv_aa_2stage_work")]
            internal static extern int ZhesvAa2stageWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr tb, int ltb, int* ipiv, int* ipiv2, System.IntPtr b, int ldb, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhetrf_aa_2stage_work")]
            internal static extern int ZhetrfAa2stageWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr tb, int ltb, int* ipiv, int* ipiv2, System.IntPtr work, int lwork);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhetrf_aa_2stage")]
            internal static extern int ZhetrfAa2stage(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, System.IntPtr a, int lda, System.IntPtr tb, int ltb, int* ipiv, int* ipiv2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhetrs_aa_2stage")]
            internal static extern int ZhetrsAa2stage(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr tb, int ltb, int* ipiv, int* ipiv2, System.IntPtr b, int ldb);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("mkl_rt", CallingConvention = CallingConvention.Cdecl,
                EntryPoint="LAPACKE_zhetrs_aa_2stage_work")]
            internal static extern int ZhetrsAa2stageWork(BLAS.LAYOUT matrixLayout, sbyte uplo, int n, int nrhs, System.IntPtr a, int lda, System.IntPtr tb, int ltb, int* ipiv, int* ipiv2, System.IntPtr b, int ldb);
        
        }
    }
}